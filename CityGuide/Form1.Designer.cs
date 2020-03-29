namespace CityGuide
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Title = new System.Windows.Forms.Label();
            this.groupBox_RadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButton_Atlanta = new System.Windows.Forms.RadioButton();
            this.radioButton_SanFrancisco = new System.Windows.Forms.RadioButton();
            this.radio_Chicago = new System.Windows.Forms.RadioButton();
            this.radio_LA = new System.Windows.Forms.RadioButton();
            this.radio_NewYork = new System.Windows.Forms.RadioButton();
            this.radio_Seattle = new System.Windows.Forms.RadioButton();
            this.label_HelloCity = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.checkBox_Area = new System.Windows.Forms.CheckBox();
            this.checkBox_Population = new System.Windows.Forms.CheckBox();
            this.checkBox_PopDensity = new System.Windows.Forms.CheckBox();
            this.label_Area = new System.Windows.Forms.Label();
            this.label_Population = new System.Windows.Forms.Label();
            this.label_PopDensity = new System.Windows.Forms.Label();
            this.textBox_TeamName = new System.Windows.Forms.TextBox();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.label_GoTeam = new System.Windows.Forms.Label();
            this.pictureBox_City = new System.Windows.Forms.PictureBox();
            this.checkBox_MedianHomePrice = new System.Windows.Forms.CheckBox();
            this.textBox_AverageHouseholdSize = new System.Windows.Forms.TextBox();
            this.checkBox_housingMarket = new System.Windows.Forms.CheckBox();
            this.label_MedianHomePrice = new System.Windows.Forms.Label();
            this.label_housingMarketSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_TeamNames = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_AverageCarsPerHousehold = new System.Windows.Forms.Label();
            this.numericUpDown_AverageCarsPerHousehold = new System.Windows.Forms.NumericUpDown();
            this.checkBox_CarsOnRoad = new System.Windows.Forms.CheckBox();
            this.label_CarsOnRoad = new System.Windows.Forms.Label();
            this.comboBox_CityName = new System.Windows.Forms.ComboBox();
            this.button_Weather = new System.Windows.Forms.Button();
            this.webBrowser_Weather = new System.Windows.Forms.WebBrowser();
            this.menuStrip_CityGuide = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveComboBox = new System.Windows.Forms.SaveFileDialog();
            this.openFileComboBox = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_RadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AverageCarsPerHousehold)).BeginInit();
            this.menuStrip_CityGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(33, 74);
            this.label_Title.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(186, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "US City Guide";
            this.label_Title.Click += new System.EventHandler(this.label_Title_Click);
            // 
            // groupBox_RadioButtons
            // 
            this.groupBox_RadioButtons.Controls.Add(this.radioButton_Atlanta);
            this.groupBox_RadioButtons.Controls.Add(this.radioButton_SanFrancisco);
            this.groupBox_RadioButtons.Controls.Add(this.radio_Chicago);
            this.groupBox_RadioButtons.Controls.Add(this.radio_LA);
            this.groupBox_RadioButtons.Controls.Add(this.radio_NewYork);
            this.groupBox_RadioButtons.Controls.Add(this.radio_Seattle);
            this.groupBox_RadioButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_RadioButtons.Location = new System.Drawing.Point(37, 127);
            this.groupBox_RadioButtons.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.groupBox_RadioButtons.Name = "groupBox_RadioButtons";
            this.groupBox_RadioButtons.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.groupBox_RadioButtons.Size = new System.Drawing.Size(159, 366);
            this.groupBox_RadioButtons.TabIndex = 1;
            this.groupBox_RadioButtons.TabStop = false;
            this.groupBox_RadioButtons.Text = "City";
            // 
            // radioButton_Atlanta
            // 
            this.radioButton_Atlanta.AutoSize = true;
            this.radioButton_Atlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Atlanta.Location = new System.Drawing.Point(14, 325);
            this.radioButton_Atlanta.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.radioButton_Atlanta.Name = "radioButton_Atlanta";
            this.radioButton_Atlanta.Size = new System.Drawing.Size(70, 21);
            this.radioButton_Atlanta.TabIndex = 5;
            this.radioButton_Atlanta.Text = "Atlanta";
            this.radioButton_Atlanta.UseVisualStyleBackColor = true;
            this.radioButton_Atlanta.CheckedChanged += new System.EventHandler(this.radioButton_Atlanta_CheckedChanged);
            // 
            // radioButton_SanFrancisco
            // 
            this.radioButton_SanFrancisco.AutoSize = true;
            this.radioButton_SanFrancisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SanFrancisco.Location = new System.Drawing.Point(15, 268);
            this.radioButton_SanFrancisco.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.radioButton_SanFrancisco.Name = "radioButton_SanFrancisco";
            this.radioButton_SanFrancisco.Size = new System.Drawing.Size(116, 21);
            this.radioButton_SanFrancisco.TabIndex = 4;
            this.radioButton_SanFrancisco.Text = "San Francisco";
            this.radioButton_SanFrancisco.UseVisualStyleBackColor = true;
            this.radioButton_SanFrancisco.CheckedChanged += new System.EventHandler(this.radioButton_SanFrancisco_CheckedChanged);
            // 
            // radio_Chicago
            // 
            this.radio_Chicago.AutoSize = true;
            this.radio_Chicago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Chicago.Location = new System.Drawing.Point(15, 208);
            this.radio_Chicago.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.radio_Chicago.Name = "radio_Chicago";
            this.radio_Chicago.Size = new System.Drawing.Size(77, 21);
            this.radio_Chicago.TabIndex = 3;
            this.radio_Chicago.Text = "Chicago";
            this.radio_Chicago.UseVisualStyleBackColor = true;
            this.radio_Chicago.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_LA
            // 
            this.radio_LA.AutoSize = true;
            this.radio_LA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_LA.Location = new System.Drawing.Point(15, 151);
            this.radio_LA.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.radio_LA.Name = "radio_LA";
            this.radio_LA.Size = new System.Drawing.Size(101, 20);
            this.radio_LA.TabIndex = 2;
            this.radio_LA.Text = "Los Angeles";
            this.radio_LA.UseVisualStyleBackColor = true;
            this.radio_LA.CheckedChanged += new System.EventHandler(this.radio_LA_CheckedChanged);
            // 
            // radio_NewYork
            // 
            this.radio_NewYork.AutoSize = true;
            this.radio_NewYork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_NewYork.Location = new System.Drawing.Point(15, 93);
            this.radio_NewYork.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.radio_NewYork.Name = "radio_NewYork";
            this.radio_NewYork.Size = new System.Drawing.Size(84, 20);
            this.radio_NewYork.TabIndex = 1;
            this.radio_NewYork.Text = "New York";
            this.radio_NewYork.UseVisualStyleBackColor = true;
            this.radio_NewYork.CheckedChanged += new System.EventHandler(this.radio_NewYork_CheckedChanged);
            // 
            // radio_Seattle
            // 
            this.radio_Seattle.AutoSize = true;
            this.radio_Seattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Seattle.Location = new System.Drawing.Point(15, 40);
            this.radio_Seattle.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.radio_Seattle.Name = "radio_Seattle";
            this.radio_Seattle.Size = new System.Drawing.Size(68, 20);
            this.radio_Seattle.TabIndex = 0;
            this.radio_Seattle.Text = "Seattle";
            this.radio_Seattle.UseVisualStyleBackColor = true;
            this.radio_Seattle.CheckedChanged += new System.EventHandler(this.radio_Seattle_CheckedChanged);
            // 
            // label_HelloCity
            // 
            this.label_HelloCity.AutoSize = true;
            this.label_HelloCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_HelloCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HelloCity.Location = new System.Drawing.Point(230, 214);
            this.label_HelloCity.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label_HelloCity.Name = "label_HelloCity";
            this.label_HelloCity.Size = new System.Drawing.Size(151, 33);
            this.label_HelloCity.TabIndex = 2;
            this.label_HelloCity.Text = "Hello_City";
            this.label_HelloCity.Visible = false;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(1052, 807);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(192, 59);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "E&xit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // checkBox_Area
            // 
            this.checkBox_Area.AutoSize = true;
            this.checkBox_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Area.Location = new System.Drawing.Point(548, 73);
            this.checkBox_Area.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.checkBox_Area.Name = "checkBox_Area";
            this.checkBox_Area.Size = new System.Drawing.Size(153, 21);
            this.checkBox_Area.TabIndex = 5;
            this.checkBox_Area.TabStop = false;
            this.checkBox_Area.Text = "Area (Square Miles)";
            this.checkBox_Area.UseVisualStyleBackColor = true;
            this.checkBox_Area.CheckedChanged += new System.EventHandler(this.checkBox_Area_CheckedChanged);
            // 
            // checkBox_Population
            // 
            this.checkBox_Population.AutoSize = true;
            this.checkBox_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Population.Location = new System.Drawing.Point(545, 217);
            this.checkBox_Population.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.checkBox_Population.Name = "checkBox_Population";
            this.checkBox_Population.Size = new System.Drawing.Size(94, 21);
            this.checkBox_Population.TabIndex = 6;
            this.checkBox_Population.Text = "Population";
            this.checkBox_Population.UseVisualStyleBackColor = true;
            this.checkBox_Population.CheckedChanged += new System.EventHandler(this.checkBox_Population_CheckedChanged);
            // 
            // checkBox_PopDensity
            // 
            this.checkBox_PopDensity.AutoSize = true;
            this.checkBox_PopDensity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CityGuide.Properties.Settings.Default, "Seattle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_PopDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_PopDensity.Location = new System.Drawing.Point(545, 390);
            this.checkBox_PopDensity.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.checkBox_PopDensity.Name = "checkBox_PopDensity";
            this.checkBox_PopDensity.Size = new System.Drawing.Size(145, 21);
            this.checkBox_PopDensity.TabIndex = 7;
            this.checkBox_PopDensity.Text = global::CityGuide.Properties.Settings.Default.Seattle;
            this.checkBox_PopDensity.UseVisualStyleBackColor = true;
            this.checkBox_PopDensity.CheckedChanged += new System.EventHandler(this.checkBox_PopDensity_CheckedChanged);
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Area.Location = new System.Drawing.Point(545, 118);
            this.label_Area.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(76, 17);
            this.label_Area.TabIndex = 8;
            this.label_Area.Text = "label_Area";
            this.label_Area.Visible = false;
            this.label_Area.Click += new System.EventHandler(this.label_Area_Click);
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Population.Location = new System.Drawing.Point(545, 260);
            this.label_Population.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(75, 17);
            this.label_Population.TabIndex = 9;
            this.label_Population.Text = "Population";
            this.label_Population.Visible = false;
            this.label_Population.Click += new System.EventHandler(this.label_Population_Click);
            // 
            // label_PopDensity
            // 
            this.label_PopDensity.AutoSize = true;
            this.label_PopDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PopDensity.Location = new System.Drawing.Point(541, 432);
            this.label_PopDensity.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_PopDensity.Name = "label_PopDensity";
            this.label_PopDensity.Size = new System.Drawing.Size(126, 17);
            this.label_PopDensity.TabIndex = 10;
            this.label_PopDensity.Text = "Population Density";
            this.label_PopDensity.Visible = false;
            this.label_PopDensity.Click += new System.EventHandler(this.label_PopDensity_Click);
            // 
            // textBox_TeamName
            // 
            this.textBox_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeamName.Location = new System.Drawing.Point(40, 710);
            this.textBox_TeamName.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.textBox_TeamName.Name = "textBox_TeamName";
            this.textBox_TeamName.Size = new System.Drawing.Size(699, 22);
            this.textBox_TeamName.TabIndex = 11;
            this.textBox_TeamName.Text = "Enter team name...";
            this.textBox_TeamName.TextChanged += new System.EventHandler(this.textBox_TeamName_TextChanged);
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeamName.Location = new System.Drawing.Point(36, 668);
            this.label_TeamName.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(95, 20);
            this.label_TeamName.TabIndex = 12;
            this.label_TeamName.Text = "Team Name";
            // 
            // label_GoTeam
            // 
            this.label_GoTeam.AutoSize = true;
            this.label_GoTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoTeam.Location = new System.Drawing.Point(772, 694);
            this.label_GoTeam.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label_GoTeam.Name = "label_GoTeam";
            this.label_GoTeam.Size = new System.Drawing.Size(126, 31);
            this.label_GoTeam.TabIndex = 13;
            this.label_GoTeam.Text = "Go Team";
            this.label_GoTeam.Visible = false;
            this.label_GoTeam.Click += new System.EventHandler(this.label_GoTeam_Click);
            // 
            // pictureBox_City
            // 
            this.pictureBox_City.Image = global::CityGuide.Properties.Resources.San_Francisco;
            this.pictureBox_City.Location = new System.Drawing.Point(230, 310);
            this.pictureBox_City.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.pictureBox_City.Name = "pictureBox_City";
            this.pictureBox_City.Size = new System.Drawing.Size(275, 183);
            this.pictureBox_City.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_City.TabIndex = 4;
            this.pictureBox_City.TabStop = false;
            this.pictureBox_City.Visible = false;
            this.pictureBox_City.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox_MedianHomePrice
            // 
            this.checkBox_MedianHomePrice.AutoSize = true;
            this.checkBox_MedianHomePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_MedianHomePrice.Location = new System.Drawing.Point(870, 73);
            this.checkBox_MedianHomePrice.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.checkBox_MedianHomePrice.Name = "checkBox_MedianHomePrice";
            this.checkBox_MedianHomePrice.Size = new System.Drawing.Size(150, 21);
            this.checkBox_MedianHomePrice.TabIndex = 14;
            this.checkBox_MedianHomePrice.Text = "Median Home Price";
            this.checkBox_MedianHomePrice.UseVisualStyleBackColor = true;
            this.checkBox_MedianHomePrice.CheckedChanged += new System.EventHandler(this.checkBox_MedianHomePrice_CheckedChanged);
            // 
            // textBox_AverageHouseholdSize
            // 
            this.textBox_AverageHouseholdSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AverageHouseholdSize.Location = new System.Drawing.Point(870, 260);
            this.textBox_AverageHouseholdSize.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.textBox_AverageHouseholdSize.Name = "textBox_AverageHouseholdSize";
            this.textBox_AverageHouseholdSize.Size = new System.Drawing.Size(227, 23);
            this.textBox_AverageHouseholdSize.TabIndex = 15;
            this.textBox_AverageHouseholdSize.Text = "Enter Family Size.";
            this.textBox_AverageHouseholdSize.TextChanged += new System.EventHandler(this.textBox_AverageHouseholdSize_TextChanged);
            // 
            // checkBox_housingMarket
            // 
            this.checkBox_housingMarket.AutoSize = true;
            this.checkBox_housingMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_housingMarket.Location = new System.Drawing.Point(870, 389);
            this.checkBox_housingMarket.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.checkBox_housingMarket.Name = "checkBox_housingMarket";
            this.checkBox_housingMarket.Size = new System.Drawing.Size(227, 21);
            this.checkBox_housingMarket.TabIndex = 16;
            this.checkBox_housingMarket.Text = "Housing Market Size ($ Billions)";
            this.checkBox_housingMarket.UseVisualStyleBackColor = true;
            this.checkBox_housingMarket.CheckedChanged += new System.EventHandler(this.checkBox_housingMarket_CheckedChanged);
            // 
            // label_MedianHomePrice
            // 
            this.label_MedianHomePrice.AutoSize = true;
            this.label_MedianHomePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MedianHomePrice.Location = new System.Drawing.Point(870, 117);
            this.label_MedianHomePrice.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_MedianHomePrice.Name = "label_MedianHomePrice";
            this.label_MedianHomePrice.Size = new System.Drawing.Size(131, 17);
            this.label_MedianHomePrice.TabIndex = 17;
            this.label_MedianHomePrice.Text = "Median Home Price";
            this.label_MedianHomePrice.Visible = false;
            this.label_MedianHomePrice.Click += new System.EventHandler(this.label_MedianHomePrice_Click);
            // 
            // label_housingMarketSize
            // 
            this.label_housingMarketSize.AutoSize = true;
            this.label_housingMarketSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_housingMarketSize.Location = new System.Drawing.Point(870, 432);
            this.label_housingMarketSize.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_housingMarketSize.Name = "label_housingMarketSize";
            this.label_housingMarketSize.Size = new System.Drawing.Size(138, 17);
            this.label_housingMarketSize.TabIndex = 18;
            this.label_housingMarketSize.Tag = "";
            this.label_housingMarketSize.Text = "Housing Market Size";
            this.label_housingMarketSize.Visible = false;
            this.label_housingMarketSize.Click += new System.EventHandler(this.label_housingMarketSize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Average Household Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox_TeamNames
            // 
            this.listBox_TeamNames.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox_TeamNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_TeamNames.FormattingEnabled = true;
            this.listBox_TeamNames.ItemHeight = 16;
            this.listBox_TeamNames.Location = new System.Drawing.Point(41, 764);
            this.listBox_TeamNames.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_TeamNames.Name = "listBox_TeamNames";
            this.listBox_TeamNames.Size = new System.Drawing.Size(697, 84);
            this.listBox_TeamNames.TabIndex = 20;
            this.listBox_TeamNames.SelectedIndexChanged += new System.EventHandler(this.listBox_TeamNames_SelectedIndexChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(840, 807);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(173, 58);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_AverageCarsPerHousehold
            // 
            this.label_AverageCarsPerHousehold.AutoSize = true;
            this.label_AverageCarsPerHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AverageCarsPerHousehold.Location = new System.Drawing.Point(870, 546);
            this.label_AverageCarsPerHousehold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AverageCarsPerHousehold.Name = "label_AverageCarsPerHousehold";
            this.label_AverageCarsPerHousehold.Size = new System.Drawing.Size(192, 17);
            this.label_AverageCarsPerHousehold.TabIndex = 22;
            this.label_AverageCarsPerHousehold.Text = "Average Cars Per Household";
            // 
            // numericUpDown_AverageCarsPerHousehold
            // 
            this.numericUpDown_AverageCarsPerHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_AverageCarsPerHousehold.Location = new System.Drawing.Point(875, 580);
            this.numericUpDown_AverageCarsPerHousehold.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_AverageCarsPerHousehold.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_AverageCarsPerHousehold.Name = "numericUpDown_AverageCarsPerHousehold";
            this.numericUpDown_AverageCarsPerHousehold.Size = new System.Drawing.Size(200, 23);
            this.numericUpDown_AverageCarsPerHousehold.TabIndex = 23;
            this.numericUpDown_AverageCarsPerHousehold.ValueChanged += new System.EventHandler(this.numericUpDown_AverageCarsPerHousehold_ValueChanged);
            // 
            // checkBox_CarsOnRoad
            // 
            this.checkBox_CarsOnRoad.AutoSize = true;
            this.checkBox_CarsOnRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CarsOnRoad.Location = new System.Drawing.Point(545, 546);
            this.checkBox_CarsOnRoad.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_CarsOnRoad.Name = "checkBox_CarsOnRoad";
            this.checkBox_CarsOnRoad.Size = new System.Drawing.Size(109, 21);
            this.checkBox_CarsOnRoad.TabIndex = 24;
            this.checkBox_CarsOnRoad.Text = "Cars on road";
            this.checkBox_CarsOnRoad.UseVisualStyleBackColor = true;
            this.checkBox_CarsOnRoad.CheckedChanged += new System.EventHandler(this.checkBox_CarsOnRoad_CheckedChanged);
            // 
            // label_CarsOnRoad
            // 
            this.label_CarsOnRoad.AutoSize = true;
            this.label_CarsOnRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CarsOnRoad.Location = new System.Drawing.Point(545, 585);
            this.label_CarsOnRoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CarsOnRoad.Name = "label_CarsOnRoad";
            this.label_CarsOnRoad.Size = new System.Drawing.Size(90, 17);
            this.label_CarsOnRoad.TabIndex = 25;
            this.label_CarsOnRoad.Text = "Cars on road";
            this.label_CarsOnRoad.Visible = false;
            this.label_CarsOnRoad.Click += new System.EventHandler(this.label_CarsOnRoad_Click);
            // 
            // comboBox_CityName
            // 
            this.comboBox_CityName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_CityName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CityName.FormattingEnabled = true;
            this.comboBox_CityName.ItemHeight = 16;
            this.comboBox_CityName.Location = new System.Drawing.Point(1166, 68);
            this.comboBox_CityName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CityName.MaxDropDownItems = 40;
            this.comboBox_CityName.Name = "comboBox_CityName";
            this.comboBox_CityName.Size = new System.Drawing.Size(419, 24);
            this.comboBox_CityName.TabIndex = 26;
            this.comboBox_CityName.Text = "     ";
            this.comboBox_CityName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Weather
            // 
            this.button_Weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Weather.Location = new System.Drawing.Point(1592, 67);
            this.button_Weather.Margin = new System.Windows.Forms.Padding(4);
            this.button_Weather.Name = "button_Weather";
            this.button_Weather.Size = new System.Drawing.Size(129, 30);
            this.button_Weather.TabIndex = 27;
            this.button_Weather.Text = "Weather";
            this.button_Weather.UseVisualStyleBackColor = true;
            this.button_Weather.Click += new System.EventHandler(this.button_Weather_Click);
            // 
            // webBrowser_Weather
            // 
            this.webBrowser_Weather.Location = new System.Drawing.Point(1163, 107);
            this.webBrowser_Weather.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser_Weather.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser_Weather.Name = "webBrowser_Weather";
            this.webBrowser_Weather.Size = new System.Drawing.Size(560, 517);
            this.webBrowser_Weather.TabIndex = 28;
            this.webBrowser_Weather.Url = new System.Uri("https://www.msn.com/en-us/weather/fullscreenmaps/today/Atlanta/we-city?iso=US&map" +
        "type=satellite&q=Atlanta", System.UriKind.Absolute);
            this.webBrowser_Weather.Visible = false;
            this.webBrowser_Weather.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip_CityGuide
            // 
            this.menuStrip_CityGuide.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_CityGuide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.weatherToolStripMenuItem});
            this.menuStrip_CityGuide.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_CityGuide.Name = "menuStrip_CityGuide";
            this.menuStrip_CityGuide.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip_CityGuide.TabIndex = 0;
            this.menuStrip_CityGuide.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "&Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 927);
            this.Controls.Add(this.webBrowser_Weather);
            this.Controls.Add(this.button_Weather);
            this.Controls.Add(this.comboBox_CityName);
            this.Controls.Add(this.label_CarsOnRoad);
            this.Controls.Add(this.checkBox_CarsOnRoad);
            this.Controls.Add(this.numericUpDown_AverageCarsPerHousehold);
            this.Controls.Add(this.label_AverageCarsPerHousehold);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.listBox_TeamNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_housingMarketSize);
            this.Controls.Add(this.label_MedianHomePrice);
            this.Controls.Add(this.checkBox_housingMarket);
            this.Controls.Add(this.textBox_AverageHouseholdSize);
            this.Controls.Add(this.checkBox_MedianHomePrice);
            this.Controls.Add(this.label_GoTeam);
            this.Controls.Add(this.label_TeamName);
            this.Controls.Add(this.textBox_TeamName);
            this.Controls.Add(this.label_PopDensity);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.checkBox_PopDensity);
            this.Controls.Add(this.checkBox_Population);
            this.Controls.Add(this.checkBox_Area);
            this.Controls.Add(this.pictureBox_City);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_HelloCity);
            this.Controls.Add(this.groupBox_RadioButtons);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.menuStrip_CityGuide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip_CityGuide;
            this.Margin = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_RadioButtons.ResumeLayout(false);
            this.groupBox_RadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AverageCarsPerHousehold)).EndInit();
            this.menuStrip_CityGuide.ResumeLayout(false);
            this.menuStrip_CityGuide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox groupBox_RadioButtons;
        private System.Windows.Forms.RadioButton radio_Seattle;
        private System.Windows.Forms.Label label_HelloCity;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.RadioButton radio_NewYork;
        private System.Windows.Forms.RadioButton radio_LA;
        private System.Windows.Forms.RadioButton radio_Chicago;
        private System.Windows.Forms.PictureBox pictureBox_City;
        private System.Windows.Forms.CheckBox checkBox_Area;
        private System.Windows.Forms.CheckBox checkBox_Population;
        private System.Windows.Forms.CheckBox checkBox_PopDensity;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.Label label_Population;
        private System.Windows.Forms.Label label_PopDensity;
        private System.Windows.Forms.TextBox textBox_TeamName;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.Label label_GoTeam;
        private System.Windows.Forms.RadioButton radioButton_Atlanta;
        private System.Windows.Forms.RadioButton radioButton_SanFrancisco;
        private System.Windows.Forms.CheckBox checkBox_MedianHomePrice;
        private System.Windows.Forms.TextBox textBox_AverageHouseholdSize;
        private System.Windows.Forms.CheckBox checkBox_housingMarket;
        private System.Windows.Forms.Label label_MedianHomePrice;
        private System.Windows.Forms.Label label_housingMarketSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_TeamNames;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_AverageCarsPerHousehold;
        private System.Windows.Forms.NumericUpDown numericUpDown_AverageCarsPerHousehold;
        private System.Windows.Forms.CheckBox checkBox_CarsOnRoad;
        private System.Windows.Forms.Label label_CarsOnRoad;
        private System.Windows.Forms.ComboBox comboBox_CityName;
        private System.Windows.Forms.Button button_Weather;
        private System.Windows.Forms.WebBrowser webBrowser_Weather;
        private System.Windows.Forms.MenuStrip menuStrip_CityGuide;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveComboBox;
        private System.Windows.Forms.OpenFileDialog openFileComboBox;
    }
}

