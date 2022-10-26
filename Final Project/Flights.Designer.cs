namespace Final_Project
{
    partial class Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.label1 = new System.Windows.Forms.Label();
            this.Way = new System.Windows.Forms.ComboBox();
            this.classes = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.date_depart = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(404, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flights";
            // 
            // Way
            // 
            this.Way.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Way.FormattingEnabled = true;
            this.Way.Items.AddRange(new object[] {
            "One way"});
            this.Way.Location = new System.Drawing.Point(248, 308);
            this.Way.Name = "Way";
            this.Way.Size = new System.Drawing.Size(173, 35);
            this.Way.TabIndex = 2;
            this.Way.Text = "-------Way------";
            this.Way.SelectedIndexChanged += new System.EventHandler(this.Way_SelectedIndexChanged);
            // 
            // classes
            // 
            this.classes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes.FormattingEnabled = true;
            this.classes.Items.AddRange(new object[] {
            "Economy"});
            this.classes.Location = new System.Drawing.Point(551, 308);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(180, 35);
            this.classes.TabIndex = 4;
            this.classes.Text = "------Class-----";
            this.classes.SelectedIndexChanged += new System.EventHandler(this.classes_SelectedIndexChanged);
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "DMK(ดอนเมือง)",
            "CNX(เชียงใหม่)",
            "HKT(ภูเก็ต)",
            "HDY(หาดใหญ่)",
            "KKC(ขอนแก่น)",
            "MAQ(แม่สอด)",
            "HHQ(หัวหิน)",
            "PRH(แพร่)",
            "UTP(อู่ตะเภา)",
            "USM(สมุย)",
            "UTH(อุดรธานี)"});
            this.from.Location = new System.Drawing.Point(187, 435);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(173, 35);
            this.from.TabIndex = 9;
            this.from.Text = "------From------";
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "DMK(ดอนเมือง)",
            "CNX(เชียงใหม่)",
            "HKT(ภูเก็ต)",
            "HDY(หาดใหญ่)",
            "KKC(ขอนแก่น)",
            "MAQ(แม่สอด)",
            "HHQ(หัวหิน)",
            "PRH(แพร่)",
            "UTP(อู่ตะเภา)",
            "USM(สมุย)",
            "UTH(อุดรธานี)"});
            this.to.Location = new System.Drawing.Point(413, 435);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(173, 35);
            this.to.TabIndex = 10;
            this.to.Text = "--------To-------";
            // 
            // date_depart
            // 
            this.date_depart.Font = new System.Drawing.Font("AngsanaUPC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_depart.Location = new System.Drawing.Point(641, 433);
            this.date_depart.MinDate = new System.DateTime(2022, 6, 28, 13, 20, 24, 0);
            this.date_depart.Name = "date_depart";
            this.date_depart.Size = new System.Drawing.Size(185, 39);
            this.date_depart.TabIndex = 11;
            this.date_depart.Value = new System.DateTime(2022, 9, 30, 0, 0, 0, 0);
            this.date_depart.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(829, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Depart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.airabc2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(682, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_depart);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.Way);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Way;
        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.DateTimePicker date_depart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}