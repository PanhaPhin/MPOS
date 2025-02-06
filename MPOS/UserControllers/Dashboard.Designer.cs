using System.Drawing;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.totalOnboardChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.bestSellingProductTable = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.bestSellingProductsCount = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.topEmployeeTable = new System.Windows.Forms.DataGridView();
			this.topEmployeeCount = new System.Windows.Forms.Label();
			this.saleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.totalOnboardChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bestSellingProductTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.topEmployeeTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saleChart)).BeginInit();
			this.SuspendLayout();
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(104, 108);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 15);
			this.label16.TabIndex = 1;
			this.label16.Text = "5% from last month";
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(20, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(303, 113);
			this.button1.TabIndex = 11;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(103, 37);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(108, 21);
			this.label19.TabIndex = 12;
			this.label19.Text = "Total Onboard";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(104, 64);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(111, 30);
			this.label20.TabIndex = 13;
			this.label20.Text = "$307,098.0";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(35, 37);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(38, 35);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox6.TabIndex = 14;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(352, 37);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(38, 35);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox7.TabIndex = 19;
			this.pictureBox7.TabStop = false;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(421, 64);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(111, 30);
			this.label17.TabIndex = 18;
			this.label17.Text = "$277,460.0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(420, 37);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(106, 21);
			this.label18.TabIndex = 17;
			this.label18.Text = "Total Revenue";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(421, 108);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(118, 15);
			this.label21.TabIndex = 15;
			this.label21.Text = "15% from last month";
			// 
			// button2
			// 
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(337, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(303, 113);
			this.button2.TabIndex = 16;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(669, 37);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(38, 35);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox8.TabIndex = 24;
			this.pictureBox8.TabStop = false;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(738, 64);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 30);
			this.label22.TabIndex = 23;
			this.label22.Text = "375,609.0";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(737, 37);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(142, 21);
			this.label23.TabIndex = 22;
			this.label23.Text = "Total Sold Products";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(738, 108);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 15);
			this.label24.TabIndex = 20;
			this.label24.Text = "5% from last month";
			// 
			// button3
			// 
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(654, 20);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(303, 113);
			this.button3.TabIndex = 21;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(987, 37);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(38, 35);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox9.TabIndex = 29;
			this.pictureBox9.TabStop = false;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(1056, 64);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(62, 30);
			this.label25.TabIndex = 28;
			this.label25.Text = "510.0";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(1055, 37);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(117, 21);
			this.label26.TabIndex = 27;
			this.label26.Text = "Purchase Today";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(1056, 108);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(111, 15);
			this.label27.TabIndex = 25;
			this.label27.Text = "45% from yesterday";
			// 
			// button4
			// 
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button4.Location = new System.Drawing.Point(972, 20);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(303, 113);
			this.button4.TabIndex = 26;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(1303, 37);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(38, 35);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox10.TabIndex = 34;
			this.pictureBox10.TabStop = false;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(1372, 64);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(78, 30);
			this.label28.TabIndex = 33;
			this.label28.Text = "1,233.0";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(1371, 37);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(90, 21);
			this.label29.TabIndex = 32;
			this.label29.Text = "Sales Today";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(1372, 108);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(111, 15);
			this.label30.TabIndex = 30;
			this.label30.Text = "12% from yesterday";
			// 
			// button5
			// 
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button5.Location = new System.Drawing.Point(1288, 20);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(303, 113);
			this.button5.TabIndex = 31;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(20, 151);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(1014, 336);
			this.button6.TabIndex = 35;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// totalOnboardChart
			// 
			this.totalOnboardChart.BackColor = System.Drawing.SystemColors.Window;
			this.totalOnboardChart.BorderlineColor = System.Drawing.SystemColors.Window;
			this.totalOnboardChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.totalOnboardChart.BorderlineWidth = 0;
			chartArea1.Name = "ChartArea1";
			this.totalOnboardChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.totalOnboardChart.Legends.Add(legend1);
			this.totalOnboardChart.Location = new System.Drawing.Point(30, 188);
			this.totalOnboardChart.Name = "totalOnboardChart";
			this.totalOnboardChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.Legend = "Legend1";
			series1.Name = "Total Onboard";
			series1.YValuesPerPoint = 4;
			this.totalOnboardChart.Series.Add(series1);
			this.totalOnboardChart.Size = new System.Drawing.Size(610, 288);
			this.totalOnboardChart.TabIndex = 36;
			this.totalOnboardChart.Text = "chart1";
			// 
			// button7
			// 
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button7.Location = new System.Drawing.Point(20, 506);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(1014, 447);
			this.button7.TabIndex = 37;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button8.Location = new System.Drawing.Point(1050, 151);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(541, 802);
			this.button8.TabIndex = 38;
			this.button8.UseVisualStyleBackColor = false;
			// 
			// bestSellingProductTable
			// 
			this.bestSellingProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.bestSellingProductTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.bestSellingProductTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bestSellingProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.bestSellingProductTable.DefaultCellStyle = dataGridViewCellStyle1;
			this.bestSellingProductTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.bestSellingProductTable.GridColor = System.Drawing.SystemColors.Window;
			this.bestSellingProductTable.Location = new System.Drawing.Point(35, 555);
			this.bestSellingProductTable.Name = "bestSellingProductTable";
			this.bestSellingProductTable.RowHeadersVisible = false;
			this.bestSellingProductTable.RowTemplate.Height = 30;
			this.bestSellingProductTable.Size = new System.Drawing.Size(981, 353);
			this.bestSellingProductTable.TabIndex = 41;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 525);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 21);
			this.label1.TabIndex = 42;
			this.label1.Text = "Best Selling Products";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(35, 523);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			// 
			// bestSellingProductsCount
			// 
			this.bestSellingProductsCount.AutoSize = true;
			this.bestSellingProductsCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bestSellingProductsCount.Location = new System.Drawing.Point(36, 923);
			this.bestSellingProductsCount.Name = "bestSellingProductsCount";
			this.bestSellingProductsCount.Size = new System.Drawing.Size(48, 19);
			this.bestSellingProductsCount.TabIndex = 44;
			this.bestSellingProductsCount.Text = "Rows: ";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1066, 167);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 46;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1096, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 21);
			this.label2.TabIndex = 45;
			this.label2.Text = "Top Employees";
			// 
			// topEmployeeTable
			// 
			this.topEmployeeTable.AllowUserToAddRows = false;
			this.topEmployeeTable.AllowUserToOrderColumns = true;
			this.topEmployeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.topEmployeeTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.topEmployeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.topEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.topEmployeeTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.topEmployeeTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.topEmployeeTable.GridColor = System.Drawing.SystemColors.Window;
			this.topEmployeeTable.Location = new System.Drawing.Point(1069, 205);
			this.topEmployeeTable.Name = "topEmployeeTable";
			this.topEmployeeTable.ReadOnly = true;
			this.topEmployeeTable.RowHeadersVisible = false;
			this.topEmployeeTable.RowTemplate.Height = 30;
			this.topEmployeeTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.topEmployeeTable.Size = new System.Drawing.Size(504, 715);
			this.topEmployeeTable.TabIndex = 47;
			// 
			// topEmployeeCount
			// 
			this.topEmployeeCount.AutoSize = true;
			this.topEmployeeCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.topEmployeeCount.Location = new System.Drawing.Point(1065, 923);
			this.topEmployeeCount.Name = "topEmployeeCount";
			this.topEmployeeCount.Size = new System.Drawing.Size(48, 19);
			this.topEmployeeCount.TabIndex = 48;
			this.topEmployeeCount.Text = "Rows: ";
			// 
			// saleChart
			// 
			this.saleChart.BackColor = System.Drawing.SystemColors.Window;
			this.saleChart.BorderlineColor = System.Drawing.SystemColors.Window;
			this.saleChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.saleChart.BorderlineWidth = 0;
			chartArea2.Name = "ChartArea1";
			this.saleChart.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.saleChart.Legends.Add(legend2);
			this.saleChart.Location = new System.Drawing.Point(645, 188);
			this.saleChart.Name = "saleChart";
			this.saleChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series2.Legend = "Legend1";
			series2.Name = "Total Sold Products";
			this.saleChart.Series.Add(series2);
			this.saleChart.Size = new System.Drawing.Size(380, 288);
			this.saleChart.TabIndex = 49;
			this.saleChart.Text = "Salling";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(920, 445);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 50;
			this.label3.Text = "Sale Graph";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.saleChart);
			this.Controls.Add(this.topEmployeeCount);
			this.Controls.Add(this.topEmployeeTable);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bestSellingProductsCount);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bestSellingProductTable);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.totalOnboardChart);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.button1);
			this.Name = "Dashboard";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.totalOnboardChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bestSellingProductTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.topEmployeeTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saleChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataVisualization.Charting.Chart totalOnboardChart;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.DataGridView bestSellingProductTable;
		private Label label1;
		private PictureBox pictureBox2;
		private Label bestSellingProductsCount;
		private PictureBox pictureBox3;
		private Label label2;
		private DataGridView topEmployeeTable;
		private Label topEmployeeCount;
		private System.Windows.Forms.DataVisualization.Charting.Chart saleChart;
		private Label label3;
	}
}
