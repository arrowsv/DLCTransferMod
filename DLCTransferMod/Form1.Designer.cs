namespace DLCTransferMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.installButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.gamePath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.installNPCs = new System.Windows.Forms.CheckBox();
            this.installWeapons = new System.Windows.Forms.CheckBox();
            this.installVehicles = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cleanProgress = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.packingProgress = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.copyProgress = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.unpackProgress = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.revertButton = new System.Windows.Forms.Button();
            this.cleaningGIF = new System.Windows.Forms.PictureBox();
            this.packingGIF = new System.Windows.Forms.PictureBox();
            this.copyingGIF = new System.Windows.Forms.PictureBox();
            this.unpackingGIF = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpackingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.installButton.ForeColor = System.Drawing.Color.White;
            this.installButton.Location = new System.Drawing.Point(318, 520);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(97, 25);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install Mod";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(27, 67);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(165, 30);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse for game folder";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // gamePath
            // 
            this.gamePath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath.Location = new System.Drawing.Point(101, 414);
            this.gamePath.Name = "gamePath";
            this.gamePath.Size = new System.Drawing.Size(192, 22);
            this.gamePath.TabIndex = 7;
            this.gamePath.Visible = false;
            this.gamePath.TextChanged += new System.EventHandler(this.gamePath_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(142)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(167, 440);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Backup VPPs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(247, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(432, 570);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.gamePath);
            this.tabPage1.Controls.Add(this.revertButton);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 174);
            this.label2.TabIndex = 17;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mod Installer";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 494);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(405, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(318, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.installNPCs);
            this.tabPage2.Controls.Add(this.installWeapons);
            this.tabPage2.Controls.Add(this.installVehicles);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.materialDivider2);
            this.tabPage2.Controls.Add(this.installButton);
            this.tabPage2.Controls.Add(this.browseButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(47, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 81);
            this.label6.TabIndex = 23;
            this.label6.Text = "The NPC\'s will consist of:\r\n\r\nVasha (for modders), DLC Samanya, and extra maraude" +
    "rs.\r\n\r\nComing soon!";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(47, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 56);
            this.label5.TabIndex = 22;
            this.label5.Text = "The weapons in this version consists of:\r\n\r\nThe Spiker, Missile Pods, Subverter a" +
    "nd Super Gauss.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(47, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 92);
            this.label4.TabIndex = 21;
            this.label4.Text = "In this version, the vehicles will be stored at these safehouses:\r\n\r\nChomper Vehi" +
    "cle: Parker, Badlands\r\n\r\nStomper Vehicle: Dust, Oasis, Eos";
            // 
            // installNPCs
            // 
            this.installNPCs.AutoSize = true;
            this.installNPCs.Enabled = false;
            this.installNPCs.Location = new System.Drawing.Point(27, 309);
            this.installNPCs.Name = "installNPCs";
            this.installNPCs.Size = new System.Drawing.Size(109, 17);
            this.installNPCs.TabIndex = 20;
            this.installNPCs.Text = "Install DLC NPC\'s";
            this.installNPCs.UseVisualStyleBackColor = true;
            // 
            // installWeapons
            // 
            this.installWeapons.AutoSize = true;
            this.installWeapons.Location = new System.Drawing.Point(27, 232);
            this.installWeapons.Name = "installWeapons";
            this.installWeapons.Size = new System.Drawing.Size(126, 17);
            this.installWeapons.TabIndex = 19;
            this.installWeapons.Text = "Install DLC Weapons";
            this.installWeapons.UseVisualStyleBackColor = true;
            // 
            // installVehicles
            // 
            this.installVehicles.AutoSize = true;
            this.installVehicles.Location = new System.Drawing.Point(27, 117);
            this.installVehicles.Name = "installVehicles";
            this.installVehicles.Size = new System.Drawing.Size(120, 17);
            this.installVehicles.TabIndex = 18;
            this.installVehicles.Text = "Install DLC Vehicles";
            this.installVehicles.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Install Settings";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(10, 494);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(405, 1);
            this.materialDivider2.TabIndex = 10;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cleaningGIF);
            this.tabPage3.Controls.Add(this.packingGIF);
            this.tabPage3.Controls.Add(this.copyingGIF);
            this.tabPage3.Controls.Add(this.unpackingGIF);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cleanProgress);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.packingProgress);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.copyProgress);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.unpackProgress);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(424, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Install";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(24, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cleaning Up";
            // 
            // cleanProgress
            // 
            this.cleanProgress.Location = new System.Drawing.Point(27, 286);
            this.cleanProgress.Name = "cleanProgress";
            this.cleanProgress.Size = new System.Drawing.Size(372, 27);
            this.cleanProgress.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(24, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "VPP Packing";
            // 
            // packingProgress
            // 
            this.packingProgress.Location = new System.Drawing.Point(27, 216);
            this.packingProgress.Name = "packingProgress";
            this.packingProgress.Size = new System.Drawing.Size(372, 27);
            this.packingProgress.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(24, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "File Copying";
            // 
            // copyProgress
            // 
            this.copyProgress.Location = new System.Drawing.Point(27, 148);
            this.copyProgress.Name = "copyProgress";
            this.copyProgress.Size = new System.Drawing.Size(372, 27);
            this.copyProgress.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(24, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "VPP Unpacking";
            // 
            // unpackProgress
            // 
            this.unpackProgress.Location = new System.Drawing.Point(27, 85);
            this.unpackProgress.Name = "unpackProgress";
            this.unpackProgress.Size = new System.Drawing.Size(372, 27);
            this.unpackProgress.Step = 50;
            this.unpackProgress.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mod Installer";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(424, 544);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Finish";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 33);
            this.label12.TabIndex = 18;
            this.label12.Text = "Install has finished!";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(24, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(391, 128);
            this.label13.TabIndex = 19;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-907, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 635);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(862, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 234);
            this.panel2.TabIndex = 0;
            // 
            // revertButton
            // 
            this.revertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("revertButton.BackgroundImage")));
            this.revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revertButton.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revertButton.ForeColor = System.Drawing.Color.White;
            this.revertButton.Location = new System.Drawing.Point(82, 442);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(79, 24);
            this.revertButton.TabIndex = 2;
            this.revertButton.Text = "Revert Mod";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Visible = false;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // cleaningGIF
            // 
            this.cleaningGIF.Image = ((System.Drawing.Image)(resources.GetObject("cleaningGIF.Image")));
            this.cleaningGIF.Location = new System.Drawing.Point(95, 266);
            this.cleaningGIF.Name = "cleaningGIF";
            this.cleaningGIF.Size = new System.Drawing.Size(17, 18);
            this.cleaningGIF.TabIndex = 32;
            this.cleaningGIF.TabStop = false;
            this.cleaningGIF.Visible = false;
            // 
            // packingGIF
            // 
            this.packingGIF.Image = ((System.Drawing.Image)(resources.GetObject("packingGIF.Image")));
            this.packingGIF.Location = new System.Drawing.Point(92, 196);
            this.packingGIF.Name = "packingGIF";
            this.packingGIF.Size = new System.Drawing.Size(17, 18);
            this.packingGIF.TabIndex = 31;
            this.packingGIF.TabStop = false;
            this.packingGIF.Visible = false;
            // 
            // copyingGIF
            // 
            this.copyingGIF.Image = ((System.Drawing.Image)(resources.GetObject("copyingGIF.Image")));
            this.copyingGIF.Location = new System.Drawing.Point(95, 129);
            this.copyingGIF.Name = "copyingGIF";
            this.copyingGIF.Size = new System.Drawing.Size(17, 18);
            this.copyingGIF.TabIndex = 30;
            this.copyingGIF.TabStop = false;
            this.copyingGIF.Visible = false;
            // 
            // unpackingGIF
            // 
            this.unpackingGIF.Image = ((System.Drawing.Image)(resources.GetObject("unpackingGIF.Image")));
            this.unpackingGIF.Location = new System.Drawing.Point(110, 67);
            this.unpackingGIF.Name = "unpackingGIF";
            this.unpackingGIF.Size = new System.Drawing.Size(17, 18);
            this.unpackingGIF.TabIndex = 29;
            this.unpackingGIF.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "If you installed DLC Vehicles:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 80);
            this.label15.TabIndex = 21;
            this.label15.Text = "• anim_files.xtbl\r\n• anim_set_filenames.xtbl\r\n• vehicle_cover.xtbl\r\n• vehicle_int" +
    "eractions.xtbl\r\n• vehicles.xtbl";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 112);
            this.label16.TabIndex = 23;
            this.label16.Text = "• character.xtbl\r\n• explosions.xtbl\r\n• items_3d.xtbl\r\n• items_inventory.xtbl\r\n• m" +
    "elee.xtbl\r\n• turrets.xtbl\r\n• weapons.xtbl";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "If you installed DLC Weapons:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 455);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(386, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "If you have checked everything, you are ready to play the game!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(678, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARROWS.DEMONSINSTALLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cleaningGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpackingGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox installNPCs;
        private System.Windows.Forms.CheckBox installWeapons;
        private System.Windows.Forms.CheckBox installVehicles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar cleanProgress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar packingProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar copyProgress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar unpackProgress;
        public System.Windows.Forms.TextBox gamePath;
        private System.Windows.Forms.PictureBox unpackingGIF;
        private System.Windows.Forms.PictureBox cleaningGIF;
        private System.Windows.Forms.PictureBox packingGIF;
        private System.Windows.Forms.PictureBox copyingGIF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

