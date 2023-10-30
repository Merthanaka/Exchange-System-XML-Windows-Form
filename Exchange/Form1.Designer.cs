namespace Exchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblusdb = new Label();
            label3 = new Label();
            lblusds = new Label();
            lbleurs = new Label();
            label6 = new Label();
            lbleurb = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnconvert = new Button();
            txtqu = new TextBox();
            txtamount = new TextBox();
            txtrate = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnub = new Button();
            btnus = new Button();
            btneb = new Button();
            btnes = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "USD/TRY(BUY):";
            label1.Click += label1_Click;
            // 
            // lblusdb
            // 
            lblusdb.AutoSize = true;
            lblusdb.BackColor = Color.Transparent;
            lblusdb.ForeColor = Color.Azure;
            lblusdb.Location = new Point(157, 14);
            lblusdb.Name = "lblusdb";
            lblusdb.Size = new Size(23, 28);
            lblusdb.TabIndex = 1;
            lblusdb.Text = "0";
            lblusdb.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 58);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 2;
            label3.Text = "USD/TRY(SELL):";
            // 
            // lblusds
            // 
            lblusds.AutoSize = true;
            lblusds.BackColor = Color.Transparent;
            lblusds.ForeColor = Color.White;
            lblusds.Location = new Point(157, 58);
            lblusds.Name = "lblusds";
            lblusds.Size = new Size(23, 28);
            lblusds.TabIndex = 3;
            lblusds.Text = "0";
            // 
            // lbleurs
            // 
            lbleurs.AutoSize = true;
            lbleurs.BackColor = Color.Transparent;
            lbleurs.ForeColor = Color.White;
            lbleurs.Location = new Point(157, 141);
            lbleurs.Name = "lbleurs";
            lbleurs.Size = new Size(23, 28);
            lbleurs.TabIndex = 7;
            lbleurs.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 141);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 6;
            label6.Text = "EUR/TRY(SELL):";
            // 
            // lbleurb
            // 
            lbleurb.AutoSize = true;
            lbleurb.BackColor = Color.Transparent;
            lbleurb.ForeColor = Color.White;
            lbleurb.Location = new Point(157, 97);
            lbleurb.Name = "lbleurb";
            lbleurb.Size = new Size(23, 28);
            lbleurb.TabIndex = 5;
            lbleurb.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 97);
            label8.Name = "label8";
            label8.Size = new Size(141, 28);
            label8.TabIndex = 4;
            label8.Text = "EUR/TRY(BUY):";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnconvert);
            groupBox1.Controls.Add(txtqu);
            groupBox1.Controls.Add(txtamount);
            groupBox1.Controls.Add(txtrate);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(334, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 408);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(251, 323);
            button1.Name = "button1";
            button1.Size = new Size(147, 57);
            button1.TabIndex = 9;
            button1.Text = "SELL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnconvert
            // 
            btnconvert.BackColor = Color.FromArgb(192, 255, 192);
            btnconvert.Location = new Point(63, 323);
            btnconvert.Name = "btnconvert";
            btnconvert.Size = new Size(147, 57);
            btnconvert.TabIndex = 8;
            btnconvert.Text = "BUY";
            btnconvert.UseVisualStyleBackColor = false;
            btnconvert.Click += btnconvert_Click;
            // 
            // txtqu
            // 
            txtqu.Location = new Point(273, 223);
            txtqu.Name = "txtqu";
            txtqu.Size = new Size(125, 34);
            txtqu.TabIndex = 6;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(273, 126);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(125, 34);
            txtamount.TabIndex = 5;
            // 
            // txtrate
            // 
            txtrate.Location = new Point(273, 46);
            txtrate.Name = "txtrate";
            txtrate.Size = new Size(125, 34);
            txtrate.TabIndex = 4;
            txtrate.TextChanged += txtrate_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(19, 223);
            label11.Name = "label11";
            label11.Size = new Size(191, 38);
            label11.TabIndex = 2;
            label11.Text = "EXCHANGED :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(19, 126);
            label10.Name = "label10";
            label10.Size = new Size(212, 38);
            label10.TabIndex = 1;
            label10.Text = "AMOUNT(TRY) :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(48, 46);
            label9.Name = "label9";
            label9.Size = new Size(93, 38);
            label9.TabIndex = 0;
            label9.Text = "RATE :";
            // 
            // btnub
            // 
            btnub.BackColor = Color.FromArgb(192, 255, 192);
            btnub.Location = new Point(234, 4);
            btnub.Name = "btnub";
            btnub.Size = new Size(94, 38);
            btnub.TabIndex = 9;
            btnub.Text = "BUY";
            btnub.UseVisualStyleBackColor = false;
            btnub.Click += btnub_Click;
            // 
            // btnus
            // 
            btnus.BackColor = Color.FromArgb(255, 192, 192);
            btnus.Location = new Point(234, 47);
            btnus.Name = "btnus";
            btnus.Size = new Size(94, 38);
            btnus.TabIndex = 10;
            btnus.Text = "SELL";
            btnus.UseVisualStyleBackColor = false;
            btnus.Click += btnus_Click;
            // 
            // btneb
            // 
            btneb.BackColor = Color.FromArgb(192, 255, 192);
            btneb.Location = new Point(234, 91);
            btneb.Name = "btneb";
            btneb.Size = new Size(94, 38);
            btneb.TabIndex = 11;
            btneb.Text = "BUY";
            btneb.UseVisualStyleBackColor = false;
            btneb.Click += btneb_Click;
            // 
            // btnes
            // 
            btnes.BackColor = Color.FromArgb(255, 192, 192);
            btnes.Location = new Point(234, 136);
            btnes.Name = "btnes";
            btnes.Size = new Size(94, 38);
            btnes.TabIndex = 12;
            btnes.Text = "SELL";
            btnes.UseVisualStyleBackColor = false;
            btnes.Click += btnes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnes);
            Controls.Add(btneb);
            Controls.Add(btnus);
            Controls.Add(btnub);
            Controls.Add(groupBox1);
            Controls.Add(lbleurs);
            Controls.Add(label6);
            Controls.Add(lbleurb);
            Controls.Add(label8);
            Controls.Add(lblusds);
            Controls.Add(label3);
            Controls.Add(lblusdb);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Exchange System";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblusdb;
        private Label label3;
        private Label lblusds;
        private Label lbleurs;
        private Label label6;
        private Label lbleurb;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnub;
        private Label label9;
        private Button btnus;
        private Button btneb;
        private Button btnes;
        private Label label11;
        private Label label10;
        private TextBox txtqu;
        private TextBox txtamount;
        private TextBox txtrate;
        private Button btnconvert;
        private Button button1;
    }
}