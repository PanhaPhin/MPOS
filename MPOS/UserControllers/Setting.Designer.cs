using static MPOS.DTOs.StaticComponents;
namespace MPOS.UserControllers
{
	partial class Setting
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
			this.SearchField = new System.Windows.Forms.TextBox();
			this.StaffCount = new System.Windows.Forms.Label();
			this.StaffListTable = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.InfoUserId = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.InfoUsername = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.InfoPassword = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.HidePassword = new System.Windows.Forms.CheckBox();
			this.InfoUserType = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.EmployeeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.RePasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.ProfileEdit = new System.Windows.Forms.Button();
			this.UserProfile = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.UserImage = new System.Windows.Forms.PictureBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.ModifyButton = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UserId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			EmployeeName = new System.Windows.Forms.ComboBox();
			this.EmployeeList = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.AddUserType = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			Username = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.AddHidePassword = new System.Windows.Forms.CheckBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.RePassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.Status = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Created = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.Updated = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StaffListTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployeeErrorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RePasswordErrorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchField
			// 
			this.SearchField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchField.Location = new System.Drawing.Point(247, 384);
			this.SearchField.Multiline = true;
			this.SearchField.Name = "SearchField";
			this.SearchField.Size = new System.Drawing.Size(426, 29);
			this.SearchField.TabIndex = 117;
			this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
			// 
			// StaffCount
			// 
			this.StaffCount.AutoSize = true;
			this.StaffCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StaffCount.Location = new System.Drawing.Point(43, 922);
			this.StaffCount.Name = "StaffCount";
			this.StaffCount.Size = new System.Drawing.Size(48, 19);
			this.StaffCount.TabIndex = 115;
			this.StaffCount.Text = "Rows: ";
			// 
			// StaffListTable
			// 
			this.StaffListTable.AllowUserToAddRows = false;
			this.StaffListTable.AllowUserToDeleteRows = false;
			this.StaffListTable.AllowUserToResizeRows = false;
			this.StaffListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StaffListTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.StaffListTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StaffListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.StaffListTable.DefaultCellStyle = dataGridViewCellStyle1;
			this.StaffListTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.StaffListTable.GridColor = System.Drawing.SystemColors.Window;
			this.StaffListTable.Location = new System.Drawing.Point(30, 429);
			this.StaffListTable.MultiSelect = false;
			this.StaffListTable.Name = "StaffListTable";
			this.StaffListTable.ReadOnly = true;
			this.StaffListTable.RowHeadersVisible = false;
			this.StaffListTable.RowTemplate.Height = 30;
			this.StaffListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StaffListTable.Size = new System.Drawing.Size(1029, 462);
			this.StaffListTable.TabIndex = 114;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 351);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 21);
			this.label1.TabIndex = 108;
			this.label1.Text = "Staff List";
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(14, 332);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1062, 625);
			this.button1.TabIndex = 105;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(14, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(1062, 294);
			this.button3.TabIndex = 123;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(64, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(174, 21);
			this.label9.TabIndex = 124;
			this.label9.Text = "User Active Information";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(65, 98);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 17);
			this.label14.TabIndex = 127;
			this.label14.Text = "User Profile";
			// 
			// InfoUserId
			// 
			this.InfoUserId.BackColor = System.Drawing.SystemColors.Window;
			this.InfoUserId.Enabled = false;
			this.InfoUserId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InfoUserId.Location = new System.Drawing.Point(213, 138);
			this.InfoUserId.Name = "InfoUserId";
			this.InfoUserId.ReadOnly = true;
			this.InfoUserId.Size = new System.Drawing.Size(152, 25);
			this.InfoUserId.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(210, 118);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 17);
			this.label15.TabIndex = 2;
			this.label15.Text = "User Id";
			// 
			// InfoUsername
			// 
			this.InfoUsername.BackColor = System.Drawing.SystemColors.Window;
			this.InfoUsername.Enabled = false;
			this.InfoUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InfoUsername.Location = new System.Drawing.Point(213, 196);
			this.InfoUsername.Name = "InfoUsername";
			this.InfoUsername.ReadOnly = true;
			this.InfoUsername.Size = new System.Drawing.Size(424, 25);
			this.InfoUsername.TabIndex = 3;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(210, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 17);
			this.label16.TabIndex = 2;
			this.label16.Text = "Username";
			// 
			// InfoPassword
			// 
			this.InfoPassword.BackColor = System.Drawing.SystemColors.Window;
			this.InfoPassword.Enabled = false;
			this.InfoPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InfoPassword.Location = new System.Drawing.Point(216, 254);
			this.InfoPassword.Name = "InfoPassword";
			this.InfoPassword.ReadOnly = true;
			this.InfoPassword.Size = new System.Drawing.Size(234, 25);
			this.InfoPassword.TabIndex = 3;
			this.InfoPassword.UseSystemPasswordChar = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(213, 234);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 17);
			this.label17.TabIndex = 2;
			this.label17.Text = "Password";
			// 
			// HidePassword
			// 
			this.HidePassword.AutoSize = true;
			this.HidePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.HidePassword.Location = new System.Drawing.Point(456, 258);
			this.HidePassword.Name = "HidePassword";
			this.HidePassword.Size = new System.Drawing.Size(54, 21);
			this.HidePassword.TabIndex = 3;
			this.HidePassword.Text = "Hide";
			this.HidePassword.UseVisualStyleBackColor = true;
			this.HidePassword.CheckedChanged += new System.EventHandler(this.HidePassword_CheckedChanged);
			// 
			// InfoUserType
			// 
			this.InfoUserType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InfoUserType.FormattingEnabled = true;
			this.InfoUserType.Location = new System.Drawing.Point(653, 196);
			this.InfoUserType.Name = "InfoUserType";
			this.InfoUserType.Size = new System.Drawing.Size(192, 25);
			this.InfoUserType.TabIndex = 6;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(650, 176);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(114, 17);
			this.label18.TabIndex = 5;
			this.label18.Text = "Choose User Type";
			// 
			// EmployeeErrorProvider
			// 
			this.EmployeeErrorProvider.ContainerControl = this;
			this.EmployeeErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("EmployeeErrorProvider.Icon")));
			// 
			// UsernameErrorProvider
			// 
			this.UsernameErrorProvider.ContainerControl = this;
			this.UsernameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("UsernameErrorProvider.Icon")));
			// 
			// PasswordErrorProvider
			// 
			this.PasswordErrorProvider.ContainerControl = this;
			this.PasswordErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("PasswordErrorProvider.Icon")));
			// 
			// RePasswordErrorProvider
			// 
			this.RePasswordErrorProvider.ContainerControl = this;
			this.RePasswordErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("RePasswordErrorProvider.Icon")));
			// 
			// ProfileEdit
			// 
			this.ProfileEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProfileEdit.Image = ((System.Drawing.Image)(resources.GetObject("ProfileEdit.Image")));
			this.ProfileEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProfileEdit.Location = new System.Drawing.Point(67, 249);
			this.ProfileEdit.Name = "ProfileEdit";
			this.ProfileEdit.Size = new System.Drawing.Size(73, 32);
			this.ProfileEdit.TabIndex = 128;
			this.ProfileEdit.Text = "Edit.";
			this.ProfileEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ProfileEdit.UseVisualStyleBackColor = true;
			this.ProfileEdit.Click += new System.EventHandler(this.ProfileEdit_Click);
			// 
			// UserProfile
			// 
			this.UserProfile.Image = ((System.Drawing.Image)(resources.GetObject("UserProfile.Image")));
			this.UserProfile.Location = new System.Drawing.Point(43, 122);
			this.UserProfile.Name = "UserProfile";
			this.UserProfile.Size = new System.Drawing.Size(120, 120);
			this.UserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.UserProfile.TabIndex = 126;
			this.UserProfile.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(34, 31);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 125;
			this.pictureBox2.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(790, 383);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 119;
			this.button2.Text = "PDF";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(880, 383);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 118;
			this.button4.Text = "Import";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(970, 383);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(84, 32);
			this.btnExcel.TabIndex = 120;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(679, 382);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 116;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(34, 349);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 109;
			this.pictureBox1.TabStop = false;
			// 
			// button6
			// 
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(1095, 15);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(504, 797);
			this.button6.TabIndex = 129;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1135, 649);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 17);
			this.label7.TabIndex = 138;
			this.label7.Text = "User Image";
			// 
			// UserImage
			// 
			this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
			this.UserImage.Location = new System.Drawing.Point(1113, 673);
			this.UserImage.Name = "UserImage";
			this.UserImage.Size = new System.Drawing.Size(120, 120);
			this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.UserImage.TabIndex = 137;
			this.UserImage.TabStop = false;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
			this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleteButton.Location = new System.Drawing.Point(1250, 757);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(106, 36);
			this.DeleteButton.TabIndex = 134;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// ModifyButton
			// 
			this.ModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButton.Image")));
			this.ModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ModifyButton.Location = new System.Drawing.Point(1474, 757);
			this.ModifyButton.Name = "ModifyButton";
			this.ModifyButton.Size = new System.Drawing.Size(106, 36);
			this.ModifyButton.TabIndex = 135;
			this.ModifyButton.Text = "Create";
			this.ModifyButton.UseVisualStyleBackColor = true;
			this.ModifyButton.Click += new System.EventHandler(ModifyButton_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
			this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ResetButton.Location = new System.Drawing.Point(1362, 757);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(106, 36);
			this.ResetButton.TabIndex = 136;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(ResetButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.panel8);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel9);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1110, 70);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 550);
			this.flowLayoutPanel1.TabIndex = 133;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.UserId);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(470, 55);
			this.panel1.TabIndex = 1;
			// 
			// UserId
			// 
			this.UserId.BackColor = System.Drawing.SystemColors.Window;
			this.UserId.Enabled = false;
			this.UserId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserId.Location = new System.Drawing.Point(24, 27);
			this.UserId.Name = "UserId";
			this.UserId.ReadOnly = true;
			this.UserId.Size = new System.Drawing.Size(152, 25);
			this.UserId.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "User Id";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(EmployeeName);
			this.panel5.Controls.Add(this.EmployeeList);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Location = new System.Drawing.Point(3, 64);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(470, 55);
			this.panel5.TabIndex = 126;
			// 
			// EmployeeName
			// 
			EmployeeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			EmployeeName.FormattingEnabled = true;
			EmployeeName.Location = new System.Drawing.Point(25, 27);
			EmployeeName.Name = "EmployeeName";
			EmployeeName.Size = new System.Drawing.Size(192, 25);
			EmployeeName.TabIndex = 4;
			// 
			// EmployeeList
			// 
			this.EmployeeList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmployeeList.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeList.Image")));
			this.EmployeeList.Location = new System.Drawing.Point(222, 27);
			this.EmployeeList.Name = "EmployeeList";
			this.EmployeeList.Size = new System.Drawing.Size(26, 25);
			this.EmployeeList.TabIndex = 129;
			this.EmployeeList.UseVisualStyleBackColor = true;
			this.EmployeeList.Click += new System.EventHandler(EmployeeList_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(21, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Choose Employee";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.AddUserType);
			this.panel8.Controls.Add(this.label12);
			this.panel8.Location = new System.Drawing.Point(3, 125);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(470, 55);
			this.panel8.TabIndex = 12;
			// 
			// AddUserType
			// 
			this.AddUserType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddUserType.FormattingEnabled = true;
			this.AddUserType.Location = new System.Drawing.Point(24, 27);
			this.AddUserType.Name = "AddUserType";
			this.AddUserType.Size = new System.Drawing.Size(192, 25);
			this.AddUserType.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(21, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 17);
			this.label12.TabIndex = 0;
			this.label12.Text = "Choose User Type";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(Username);
			this.panel2.Location = new System.Drawing.Point(3, 186);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(470, 55);
			this.panel2.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Username";
			// 
			// Username
			// 
			Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			Username.Location = new System.Drawing.Point(25, 27);
			Username.Name = "Username";
			Username.Size = new System.Drawing.Size(234, 25);
			Username.TabIndex = 1;
			Username.TextChanged += new System.EventHandler(Setting_Username_TextChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.AddHidePassword);
			this.panel3.Controls.Add(this.Password);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(3, 247);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(470, 55);
			this.panel3.TabIndex = 9;
			// 
			// AddHidePassword
			// 
			this.AddHidePassword.AutoSize = true;
			this.AddHidePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.AddHidePassword.Location = new System.Drawing.Point(290, 29);
			this.AddHidePassword.Name = "AddHidePassword";
			this.AddHidePassword.Size = new System.Drawing.Size(54, 21);
			this.AddHidePassword.TabIndex = 129;
			this.AddHidePassword.Text = "Hide";
			this.AddHidePassword.UseVisualStyleBackColor = true;
			this.AddHidePassword.CheckedChanged += new System.EventHandler(AddHidePassword_CheckedChanged);
			// 
			// Password
			// 
			this.Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password.Location = new System.Drawing.Point(24, 27);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(234, 25);
			this.Password.TabIndex = 1;
			this.Password.UseSystemPasswordChar = true;
			this.Password.TextAlignChanged += new System.EventHandler(Password_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Password";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.RePassword);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(3, 308);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(470, 55);
			this.panel4.TabIndex = 10;
			// 
			// RePassword
			// 
			this.RePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RePassword.Location = new System.Drawing.Point(24, 27);
			this.RePassword.Name = "RePassword";
			this.RePassword.Size = new System.Drawing.Size(234, 25);
			this.RePassword.TabIndex = 1;
			this.RePassword.UseSystemPasswordChar = true;
			this.ResetButton.TextChanged += new System.EventHandler(RePassword_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Re-Password";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.Status);
			this.panel9.Controls.Add(this.label13);
			this.panel9.Location = new System.Drawing.Point(3, 369);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(470, 55);
			this.panel9.TabIndex = 11;
			// 
			// Status
			// 
			this.Status.AutoSize = true;
			this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Status.Location = new System.Drawing.Point(24, 28);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(61, 21);
			this.Status.TabIndex = 2;
			this.Status.Text = "Active";
			this.Status.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(21, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 17);
			this.label13.TabIndex = 0;
			this.label13.Text = "User Status";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.Created);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Location = new System.Drawing.Point(3, 430);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(470, 55);
			this.panel6.TabIndex = 7;
			// 
			// Created
			// 
			this.Created.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Created.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Created.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Created.Location = new System.Drawing.Point(24, 27);
			this.Created.Name = "Created";
			this.Created.Size = new System.Drawing.Size(122, 25);
			this.Created.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(21, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Created";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.Updated);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Location = new System.Drawing.Point(3, 491);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(470, 55);
			this.panel7.TabIndex = 8;
			// 
			// Updated
			// 
			this.Updated.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Updated.Location = new System.Drawing.Point(24, 27);
			this.Updated.Name = "Updated";
			this.Updated.Size = new System.Drawing.Size(122, 25);
			this.Updated.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(21, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Updated";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1110, 31);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 132;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1140, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 21);
			this.label2.TabIndex = 131;
			this.label2.Text = "Add-Modify User";
			// 
			// Setting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.UserImage);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.ModifyButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.ProfileEdit);
			this.Controls.Add(this.InfoUserType);
			this.Controls.Add(this.HidePassword);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.InfoPassword);
			this.Controls.Add(this.InfoUsername);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.InfoUserId);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.UserProfile);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.SearchField);
			this.Controls.Add(this.StaffCount);
			this.Controls.Add(this.StaffListTable);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Setting";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.StaffListTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployeeErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RePasswordErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox SearchField;
		private System.Windows.Forms.Label StaffCount;
		private System.Windows.Forms.DataGridView StaffListTable;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox UserProfile;
		private System.Windows.Forms.TextBox InfoUserId;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox InfoUsername;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox InfoPassword;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox HidePassword;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button ProfileEdit;
		private System.Windows.Forms.ComboBox InfoUserType;
		private System.Windows.Forms.ErrorProvider EmployeeErrorProvider;
		private System.Windows.Forms.ErrorProvider UsernameErrorProvider;
		private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
		private System.Windows.Forms.ErrorProvider RePasswordErrorProvider;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox UserImage;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button ModifyButton;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox UserId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel5;
		public static System.Windows.Forms.ComboBox EmployeeName;
		private System.Windows.Forms.Button EmployeeList;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.ComboBox AddUserType;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		public static System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox AddHidePassword;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox RePassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.CheckBox Status;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DateTimePicker Created;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.DateTimePicker Updated;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
	}
}
