namespace E94106012_practice_4_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            sellsold = new Button();
            own3 = new Label();
            own2 = new Label();
            own1 = new Label();
            fruit = new CheckBox();
            fertilizer = new CheckBox();
            seed = new CheckBox();
            Labelmoney = new Label();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1507, 891);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.ImeMode = ImeMode.On;
            tabPage1.Location = new Point(4, 48);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1499, 839);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "農場";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(830, 641);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "工具";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(532, 94);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(102, 43);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "鐮刀";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(375, 94);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 43);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "肥料";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(217, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 43);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "種子";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(35, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 43);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "澆水壺";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sellsold);
            tabPage2.Controls.Add(own3);
            tabPage2.Controls.Add(own2);
            tabPage2.Controls.Add(own1);
            tabPage2.Controls.Add(fruit);
            tabPage2.Controls.Add(fertilizer);
            tabPage2.Controls.Add(seed);
            tabPage2.Controls.Add(Labelmoney);
            tabPage2.ImeMode = ImeMode.On;
            tabPage2.Location = new Point(4, 48);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1499, 839);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "商店";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // sellsold
            // 
            sellsold.Location = new Point(634, 596);
            sellsold.Name = "sellsold";
            sellsold.Size = new Size(223, 64);
            sellsold.TabIndex = 7;
            sellsold.Text = "買/賣";
            sellsold.UseVisualStyleBackColor = true;
            sellsold.Click += sellsold_Click;
            // 
            // own3
            // 
            own3.AutoSize = true;
            own3.Location = new Point(1063, 390);
            own3.Name = "own3";
            own3.Size = new Size(84, 39);
            own3.TabIndex = 6;
            own3.Text = "擁有:";
            own3.Click += label4_Click;
            // 
            // own2
            // 
            own2.AutoSize = true;
            own2.Location = new Point(684, 390);
            own2.Name = "own2";
            own2.Size = new Size(84, 39);
            own2.TabIndex = 5;
            own2.Text = "擁有:";
            // 
            // own1
            // 
            own1.AutoSize = true;
            own1.Location = new Point(323, 390);
            own1.Name = "own1";
            own1.Size = new Size(84, 39);
            own1.TabIndex = 4;
            own1.Text = "擁有:";
            // 
            // fruit
            // 
            fruit.AutoSize = true;
            fruit.Location = new Point(1064, 285);
            fruit.Name = "fruit";
            fruit.Size = new Size(103, 43);
            fruit.TabIndex = 3;
            fruit.Text = "果實";
            fruit.UseVisualStyleBackColor = true;
            fruit.CheckedChanged += fruit_CheckedChanged;
            // 
            // fertilizer
            // 
            fertilizer.AutoSize = true;
            fertilizer.Location = new Point(689, 285);
            fertilizer.Name = "fertilizer";
            fertilizer.Size = new Size(103, 43);
            fertilizer.TabIndex = 2;
            fertilizer.Text = "肥料";
            fertilizer.UseVisualStyleBackColor = true;
            fertilizer.CheckedChanged += fertilizer_CheckedChanged;
            // 
            // seed
            // 
            seed.AutoSize = true;
            seed.Location = new Point(330, 285);
            seed.Name = "seed";
            seed.Size = new Size(103, 43);
            seed.TabIndex = 1;
            seed.Text = "種子";
            seed.UseVisualStyleBackColor = true;
            seed.CheckedChanged += seed_CheckedChanged;
            // 
            // Labelmoney
            // 
            Labelmoney.AutoSize = true;
            Labelmoney.Location = new Point(689, 124);
            Labelmoney.Name = "Labelmoney";
            Labelmoney.Size = new Size(138, 39);
            Labelmoney.TabIndex = 0;
            Labelmoney.Text = "金錢:100";
            Labelmoney.Click += Labelmoney_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dirt.jpeg");
            imageList1.Images.SetKeyName(1, "seed.jpg");
            imageList1.Images.SetKeyName(2, "crop.jpg");
            imageList1.Images.SetKeyName(3, "watermelon.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 893);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        public TabPage tabPage1;
        private ImageList imageList1;
        private Label own3;
        private Label own2;
        private Label own1;
        private CheckBox fruit;
        private CheckBox fertilizer;
        private CheckBox seed;
        private Label Labelmoney;
        private Button sellsold;
        private Button[] farm;
    }
}