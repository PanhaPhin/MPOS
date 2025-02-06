using MPOS.Controllers;
using MPOS.Entities;
using MPOS.UserControllers;
using MPOS.ViewReports;
using System.Drawing;
using System.Windows.Forms;
using static MPOS.Program;
using static MPOS.Views.Login;

namespace MPOS.Views
{
	enum EnumMenuOptions
	{
		dashboard,
		orders,
		products,
		category,
		purchase,
		supplier,
		stock,
		customers,
		employee,
		analytics,
		settings
	}

	public partial class MPOS : Form
	{
		public static Views.MPOS mPOS;
		ProductConnection connection;
		Options options;
		
		public MPOS()
		{
			InitializeComponent();
			txtUsername.Text = Username;

			connection = new ProductConnection();
			options = new Options();
			dashboardTab.BackColor = SystemColors.ControlLight;
			options.ShowUserControl<Dashboard>(container, new Dashboard());
			dashboardTab.Enabled = false;
		}

		private void SelectOptions(EnumMenuOptions option)
		{
			dashboardTab.BackColor = SystemColors.Window;
			orderTab.BackColor = SystemColors.Window;
			productTab.BackColor = SystemColors.Window;
			stockTab.BackColor = SystemColors.Window;
			purchaseTab.BackColor = SystemColors.Window;
			supplierTab.BackColor = SystemColors.Window;
			categoryTab.BackColor = SystemColors.Window;
			customerTab.BackColor = SystemColors.Window;
			employeeTab.BackColor = SystemColors.Window;
			analyticTab.BackColor = SystemColors.Window;
			settingTab.BackColor = SystemColors.Window;

			dashboardTab.Enabled = true;
			orderTab.Enabled = true;
			productTab.Enabled = true;
			customerTab.Enabled = true;
			stockTab.Enabled = true;
			purchaseTab.Enabled = true;
			supplierTab.Enabled = true;
			categoryTab.Enabled = true;
			employeeTab.Enabled = true;
			analyticTab.Enabled = true;
			settingTab.Enabled = true;

			//toast.Close();


			container.Controls.Clear();

			switch (option)
			{
				case EnumMenuOptions.dashboard:
					{
						dashboardTab.BackColor = SystemColors.ControlLight;
						options.ShowUserControl<Dashboard>(container, new Dashboard());
						dashboardTab.Enabled = false;
						break;
					}
				case EnumMenuOptions.orders:
					{
						orderTab.BackColor = SystemColors.ControlLight;
						options.ShowUserControl<Order>(container, new Order());
						orderTab.Enabled = false;
						break;
					}
				case EnumMenuOptions.products:
					{
						productTab.BackColor = SystemColors.ControlLight;
						options.ShowUserControl<Products>(container, new Products());
						// productTab.Enabled = false;
						break;
					}
				case EnumMenuOptions.customers:
					{
						customerTab.BackColor = SystemColors.ControlLight;
						customerTab.Enabled = false;
						options.ShowUserControl<Customer>(container, new Customer());
						break;
					}
				case EnumMenuOptions.analytics:
					{
						analyticTab.BackColor = SystemColors.ControlLight;
						analyticTab.Enabled = false;
						//ViewReport report = new ViewReport();
						//report.Show();
						break;
					}
				case EnumMenuOptions.settings:
					{
						settingTab.BackColor = SystemColors.ControlLight;
						settingTab.Enabled = false;
						options.ShowUserControl<Setting>(container, new Setting());
						break;
					}
				case EnumMenuOptions.employee:
					{
						employeeTab.BackColor= SystemColors.ControlLight;
						employeeTab.Enabled = false;
						options.ShowUserControl<Employee>(container, new Employee());
						break;
					}
				case EnumMenuOptions.stock:
					{
						stockTab.BackColor = SystemColors.ControlLight;
						options.ShowUserControl<Stock>(container, new Stock());
						stockTab.Enabled = false;
						break;
					}
				case EnumMenuOptions.purchase:
					{
						purchaseTab.BackColor = SystemColors.ControlLight;
						purchaseTab.Enabled = false;
						options.ShowUserControl<Purchase>(container, new Purchase());
						break;
					}
				case EnumMenuOptions.supplier:
					{
						supplierTab.BackColor = SystemColors.ControlLight;
						supplierTab.Enabled = false;
						options.ShowUserControl<Supplier>(container, new Supplier());
						break;
					}
				case EnumMenuOptions.category:
					{
						categoryTab.BackColor = SystemColors.ControlLight;
						categoryTab.Enabled = false;
						options.ShowUserControl<Category>(container, new Category());
						break;
					}

				default: break;
			}
		}

		private bool productSliderAction = false;
		private void productSliderTransition_Tick(object sender, System.EventArgs e)
		{
			if (productSliderAction == false)
			{
				menuProduct.Height += 20;
				if(menuProduct.Height >= 295)
				{
					productSliderTransition.Stop();
					menuProduct.Height = 295;
					productSliderAction = true;
				}
			}
			else
			{
				menuProduct.Height -= 20;
				if (menuProduct.Height <= 58)
				{
					productSliderTransition.Stop();
					menuProduct.Height = 58;
					productSliderAction = false;
				}
			}
		}

		private void productTab_Click(object sender, System.EventArgs e)
		{
			productSliderTransition.Start();
			SelectOptions(EnumMenuOptions.products);
		}
		private void CategoryTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.category);
		
		private void StockTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.stock);

		private void PurchaseTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.purchase);

		private void SupplierTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.supplier);

		private void dashboardTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.dashboard);

		private void orderTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.orders);

		private void customerTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.customers);

		private void employeeTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.employee);

		private void analyticTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.analytics);

		private void settingTab_Click(object sender, System.EventArgs e) => SelectOptions(EnumMenuOptions.settings);

		private void MPOS_FormClosed(object sender, FormClosedEventArgs e)
		{
			login.Close();
		}
	}
}
