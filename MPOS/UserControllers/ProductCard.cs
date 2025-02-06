using System;
using System.Windows.Forms;
using static MPOS.UserControllers.Order;
using MPOS.Helpers;
using System.Drawing;

namespace MPOS.UserControllers
{
	public partial class ProductCard : UserControl
	{
		public ProductCard()
		{
			InitializeComponent();
		}

		private void card_Click(object sender, EventArgs e)
		{
			bool isTrue = false;
			this.card.FlatStyle = FlatStyle.Popup;
			this.card.FlatAppearance.BorderColor = Color.Black;
			this.card.BackColor = SystemColors.Window;
			this.card.FlatAppearance.BorderSize = 1;
			CardOrder cardOrder = new CardOrder();
			cardOrderDetail(cardOrder);
			ComponentHelper.productOrderCount++;
			if (orderContainer.Controls.Count > 0)
			{
				foreach (CardOrder child in orderContainer.Controls)
				{
					if (string.Compare(child.productName.Text, cardOrder.productName.Text) == 0)
					{
						var q = Convert.ToInt32(double.Parse(child.quantity.Text.ToString()));
						q++;
						child.quantity.Text = q.ToString("#,###.0");
						isTrue = true;
						break;
					}
					else
						isTrue = false;
				}

				if (!isTrue)
					orderContainer.Controls.Add(cardOrder);
			}
			else
				orderContainer.Controls.Add(cardOrder);

			productOrderCount.Text = $"Subtotal: {ComponentHelper.productOrderCount.ToString("#,###.0")}";
		}


		private void cardOrderDetail(CardOrder cardOrder)
		{
			cardOrder.productName.Text = productName.Text;
			cardOrder.price.Text = price.Text;
			//var qty = int.Parse(Quantity.Text);
			cardOrder.quantity.Text = "1.0";
		}
	}
}
