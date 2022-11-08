namespace LogBook
{
    partial class UserControl1
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.lastDayLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inspectionWorkCB = new System.Windows.Forms.ComboBox();
            this.classWorkCB = new System.Windows.Forms.ComboBox();
            this.istirakRadioB = new System.Windows.Forms.RadioButton();
            this.gecikibRadioB = new System.Windows.Forms.RadioButton();
            this.gelmeyibRadioB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(51, 58);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(63, 25);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "label2";
            // 
            // lastDayLbl
            // 
            this.lastDayLbl.AutoSize = true;
            this.lastDayLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastDayLbl.Location = new System.Drawing.Point(347, 58);
            this.lastDayLbl.Name = "lastDayLbl";
            this.lastDayLbl.Size = new System.Drawing.Size(63, 25);
            this.lastDayLbl.TabIndex = 2;
            this.lastDayLbl.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(1174, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(117, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LogBook.Properties.Resources.icons8_diamond_50;
            this.pictureBox3.Location = new System.Drawing.Point(74, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "D3";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LogBook.Properties.Resources.icons8_diamond_50;
            this.pictureBox2.Location = new System.Drawing.Point(37, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "D2";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogBook.Properties.Resources.icons8_diamond_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "D1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inspectionWorkCB
            // 
            this.inspectionWorkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inspectionWorkCB.FormattingEnabled = true;
            this.inspectionWorkCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.inspectionWorkCB.Location = new System.Drawing.Point(825, 50);
            this.inspectionWorkCB.Name = "inspectionWorkCB";
            this.inspectionWorkCB.Size = new System.Drawing.Size(43, 28);
            this.inspectionWorkCB.TabIndex = 7;
            // 
            // classWorkCB
            // 
            this.classWorkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classWorkCB.FormattingEnabled = true;
            this.classWorkCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.classWorkCB.Location = new System.Drawing.Point(1023, 50);
            this.classWorkCB.Name = "classWorkCB";
            this.classWorkCB.Size = new System.Drawing.Size(43, 28);
            this.classWorkCB.TabIndex = 7;
            // 
            // istirakRadioB
            // 
            this.istirakRadioB.AutoSize = true;
            this.istirakRadioB.Location = new System.Drawing.Point(600, 62);
            this.istirakRadioB.Name = "istirakRadioB";
            this.istirakRadioB.Size = new System.Drawing.Size(17, 16);
            this.istirakRadioB.TabIndex = 8;
            this.istirakRadioB.TabStop = true;
            this.istirakRadioB.UseVisualStyleBackColor = true;
            // 
            // gecikibRadioB
            // 
            this.gecikibRadioB.AutoSize = true;
            this.gecikibRadioB.Location = new System.Drawing.Point(623, 62);
            this.gecikibRadioB.Name = "gecikibRadioB";
            this.gecikibRadioB.Size = new System.Drawing.Size(17, 16);
            this.gecikibRadioB.TabIndex = 8;
            this.gecikibRadioB.TabStop = true;
            this.gecikibRadioB.UseVisualStyleBackColor = true;
            // 
            // gelmeyibRadioB
            // 
            this.gelmeyibRadioB.AutoSize = true;
            this.gelmeyibRadioB.Location = new System.Drawing.Point(646, 62);
            this.gelmeyibRadioB.Name = "gelmeyibRadioB";
            this.gelmeyibRadioB.Size = new System.Drawing.Size(17, 16);
            this.gelmeyibRadioB.TabIndex = 8;
            this.gelmeyibRadioB.TabStop = true;
            this.gelmeyibRadioB.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gelmeyibRadioB);
            this.Controls.Add(this.gecikibRadioB);
            this.Controls.Add(this.istirakRadioB);
            this.Controls.Add(this.classWorkCB);
            this.Controls.Add(this.inspectionWorkCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lastDayLbl);
            this.Controls.Add(this.nameLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1441, 153);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lastDayLbl;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public Label nameLbl;
        public ComboBox inspectionWorkCB;
        public ComboBox classWorkCB;
        private RadioButton istirakRadioB;
        private RadioButton gecikibRadioB;
        private RadioButton gelmeyibRadioB;
    }
}
