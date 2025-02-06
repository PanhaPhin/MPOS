using MPOS.Database;
using MPOS.Entities;
using MPOS.Services;
using MPOS.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static MPOS.Views.Login;
using static MPOS.Views.MPOS;
using static MPOS.DTOs.StaticComponents;

namespace MPOS.UserControllers
{
	public partial class Setting : UserControl, IFormats
	{
		private DbDataContext dbDataContext;
		private SettingConnection SettingConnection;
		private readonly string DateFormat = "MM/dd/yyyy";
		ToolTip RePasswordToolTip;
		public Setting()
		{
			InitializeComponent();
			dbDataContext = new DbDataContext();
			SettingConnection = new SettingConnection();
			CheckUserActive();
			GetUserInformation();
			this.InfoUserType.SelectedIndex = 0;
			GetStaffList(dbDataContext.Users.ToList());
			GetUserTypes();
			this.UserId.Text = GetUserIdDESC().ToString();
		}

		private struct StaffInfo
		{
			public int Id;
			public string Name;
			public string UserType;
			public string Status;
			public DateTime Created;
			public DateTime Updated;
		}
		
		private void ProfileEdit_Click(object sender, EventArgs e)
		{

		}
		
		private void HidePassword_CheckedChanged(object sender, EventArgs e)
		{
			if (this.HidePassword.Checked)
				this.InfoPassword.UseSystemPasswordChar = false;
			else
				this.InfoPassword.UseSystemPasswordChar = true;
		}
		
		private void CheckUserActive()
		{
			foreach (var user in dbDataContext.Users)
			{
				if (user.Username.Equals(Views.Login.Username) && user.Password.Equals(Views.Login.Password))
				{
					user.Status = 1;
					dbDataContext.SubmitChanges();
				}
				else
				{
					user.Status = 0;
					dbDataContext.SubmitChanges();
				}
			}
		}
		
		private void GetUserInformation()
		{
			FuncGetUserInformationResult UserInfo = dbDataContext.FuncGetUserInformation(Views.Login.Username, Views.Login.Password).FirstOrDefault();
			if (UserInfo != null)
			{
				this.InfoUserId.Text = UserInfo.UserId.ToString();
				this.InfoUsername.Text = UserInfo.Username.ToString();
				this.InfoPassword.Text = UserInfo.Password.ToString();
				this.InfoUserType.Items.Add(UserInfo.UserType);
			}
		}
		
		private void GetStaffList(List<User> users)
		{
			List<StaffInfo> StaffList = new List<StaffInfo>();
			foreach (var user in users)
			{
				StaffInfo Staff = new StaffInfo();
				Staff.Id = user.UserId;
				Staff.Name = user.Username;
				Staff.UserType = dbDataContext.UserTypes.FirstOrDefault(x => x.Id == user.UserTypeId).TypeName;
				if (user.Status == 1)
					Staff.Status = "Active";
				else
					Staff.Status = "Deactivated";
				Staff.Created = user.Created;
				Staff.Updated = user.Updated;
				StaffList.Add(Staff);
			}
			
			DataTable table = new DataTable();
			table.Columns.Add("User Id");
			table.Columns.Add("Username");
			table.Columns.Add("User Type");
			table.Columns.Add("User Status");
			table.Columns.Add("Created Date");
			table.Columns.Add("Updated Date");

			foreach(var staff in StaffList)
			{
				var row = table.NewRow();
				row[0] = staff.Id;
				row[1] = staff.Name;
				row[2] = staff.UserType;
				row[3] = staff.Status;
				row[4] = staff.Created.ToShortDateString();
				row[5] = staff.Updated.ToShortDateString();
				table.Rows.Add(row);
			}

			this.StaffListTable.DataSource = table;
			this.StaffListTable.CellClick += StaffListTable_CellClick;
			FormatCells(this.StaffListTable);
		}

		private void StaffListTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) {
				int userId = int.Parse(this.StaffListTable.Rows[e.RowIndex].Cells[0].Value.ToString());
				GetUser(userId);
			}
		}

		private void StaffListTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 3 && e.Value != null && e.Value.ToString().Equals("Active"))
			{
				e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				e.CellStyle.ForeColor = System.Drawing.Color.Blue;
				e.CellStyle.SelectionForeColor = System.Drawing.Color.Blue;
			}
		}

		public void ResetData()
		{
			this.UserId.Text = GetUserIdDESC().ToString();
			EmployeeName.Items.Clear();
			EmployeeName.Text = string.Empty;
			this.AddUserType.SelectedIndex = 0;
			Username.Text = string.Empty;
			this.Password.Text = string.Empty;
			this.RePassword.Text = string.Empty;
			this.AddHidePassword.Checked = false;
			this.Status.Checked = false;
			this.Created.Value = DateTime.Now;
			this.Updated.Value = DateTime.Now;
			this.ModifyButton.Text = "Create";
			this.DeleteButton.Enabled = false;
			this.StaffListTable.ClearSelection();
		}

		public void FormatCells(DataGridView gridView)
		{
			gridView.CellFormatting += new DataGridViewCellFormattingEventHandler(StaffListTable_CellFormatting);
			gridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.StaffCount.Text = $"Rows: {gridView.Rows.Count.ToString("#,###.0")}";

			gridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}

		public void Search(TextBox text)
		{
			if (!string.IsNullOrEmpty(text.Text) || !string.IsNullOrWhiteSpace(text.Text))
			{
				var users = SettingConnection.GetByName(text.Text);
				if (users != null)
					GetStaffList(users);
				else
					this.StaffListTable.DataSource = null;
			}
			else
				GetStaffList(dbDataContext.Users.ToList());
		}

		private void SearchField_TextChanged(object sender, EventArgs e) => Search(this.SearchField);

		private void EmployeeList_Click(object sender, EventArgs e)
		{
			EmployeeListView employeeList = new EmployeeListView();
			employeeList.Owner = mPOS;
			employeeList.ShowDialog();
		}

		private void GetUserTypes()
		{
			var UserTypes = dbDataContext.UserTypes.Select(u => u.TypeName).ToList();
			this.AddUserType.Items.AddRange(UserTypes.ToArray());
			this.AddUserType.SelectedIndex = 0;
		}

		private int GetUserIdDESC() => dbDataContext.Users.OrderByDescending(user => user.UserId).Select(user => user.UserId).FirstOrDefault() + 1;

		private void ResetButton_Click(object sender, EventArgs e) => ResetData();
		private void ModifyButton_Click(object sender, EventArgs e)
		{ 
			if(string.IsNullOrEmpty(Username.Text) || string.IsNullOrWhiteSpace(Username.Text))
			{
				this.UsernameErrorProvider.SetError(Username, "Username require.");
				return;
			}else
				this.UsernameErrorProvider.SetError(Username, string.Empty);

			if(string.IsNullOrEmpty(this.Password.Text) || string.IsNullOrWhiteSpace(this.Password.Text))
			{
				this.PasswordErrorProvider.SetError(this.Password, "Password require.");
				return;
			}
			else
				this.PasswordErrorProvider.SetError(this.Password, string.Empty);

			if(string.IsNullOrEmpty(this.RePassword.Text) || string.IsNullOrWhiteSpace(this.RePassword.Text))
			{
				this.RePasswordErrorProvider.SetError(this.RePassword, "Re-Password require.");
				return;
			}else

				this.RePasswordErrorProvider.SetError(this.RePassword, string.Empty);
			if (!this.RePassword.Text.Equals(this.Password.Text))
			{
				RePasswordToolTip = new ToolTip();
				RePasswordToolTip.IsBalloon = true;
				RePasswordToolTip.ToolTipTitle = "Warning Re-Password";
				RePasswordToolTip.ToolTipIcon = ToolTipIcon.Warning;
				RePasswordToolTip.Show(string.Empty, this.RePassword);
				RePasswordToolTip.Show("Please Confirm Password.", this.RePassword, this.RePassword.Width + 2, 10);
				return;
			}

			if (this.ModifyButton.Text.Equals("Create"))
			{
				var message = SettingConnection.Insert(SetUser());
				Toast toast = new Toast(Notification.Accept, "Create User", message);
				toast.Show();
				GetStaffList(dbDataContext.Users.ToList());
				ResetData();
			}
		}

		private User SetUser()
		{
			var user = new User();
			user.UserId = int.Parse(this.UserId.Text);
			user.EmployeeId = dbDataContext.Employees.FirstOrDefault(emp => emp.Name.Equals(EmployeeName.Items[0])).Id;
			user.UserTypeId = dbDataContext.UserTypes.FirstOrDefault(type => type.TypeName.Equals(this.AddUserType.SelectedItem)).Id;
			user.Username = Username.Text;
			user.Password = Password.Text;
			user.Status = (byte)(Status.Checked ? 1 : 0);
			user.Created = DateTime.Now;
			user.Updated = DateTime.Now;

			return user;
		}

		private void GetUser(int userId)
		{
			var user = SettingConnection.GetById(userId);
			this.UserId.Text = user.UserId.ToString();
			var employeeName = dbDataContext.Employees.FirstOrDefault(emp => emp.Id.Equals(user.EmployeeId)).Name;
			EmployeeName.Items.Clear();
			EmployeeName.Items.Add(employeeName);
			EmployeeName.SelectedIndex = 0;
			var userTypeId = dbDataContext.UserTypes.FirstOrDefault(type => type.Id.Equals(user.UserTypeId)).Id;
			this.AddUserType.SelectedIndex = userTypeId - 1;
			Username.Text = user.Username;
			this.Password.Text = user.Password;
			this.RePassword.Text = user.Password;
			this.AddHidePassword.Checked = false;
			this.Status.Checked = user.Status == 1 ? true : false;
			this.Created.Text = user.Created.ToString();
			this.Updated.Text = user.Updated.ToString();
			this.DeleteButton.Enabled = true;
			this.ModifyButton.Text = "Update";
		}

		private void Setting_Username_TextChanged(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrEmpty(Username.Text) || !string.IsNullOrWhiteSpace(Username.Text))
				this.UsernameErrorProvider.SetError(Username, string.Empty);
		}

		private void RePassword_TextChanged(object sender, System.EventArgs e)
		{
			if (RePasswordToolTip != null)
				RePasswordToolTip.Dispose();
			if (!string.IsNullOrEmpty(this.RePassword.Text) || !string.IsNullOrWhiteSpace(this.RePassword.Text))
			{
				this.RePasswordErrorProvider.SetError(this.RePassword, string.Empty);
			}
		}

		private void Password_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.Password.Text) || !string.IsNullOrWhiteSpace(this.Password.Text))
			{
				this.PasswordErrorProvider.SetError(this.Password, string.Empty);
			}
		}

		private void AddHidePassword_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AddHidePassword.Checked)
			{
				this.Password.UseSystemPasswordChar = false;
				this.RePassword.UseSystemPasswordChar = false;
			}
			else
			{
				this.Password.UseSystemPasswordChar = true;
				this.RePassword.UseSystemPasswordChar = true;
			}
		}
	}
}


