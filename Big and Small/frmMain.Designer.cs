namespace Big_and_Small
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBig = new System.Windows.Forms.TextBox();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBFromBank = new System.Windows.Forms.Button();
            this.lblConditionWL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.picResult1 = new System.Windows.Forms.PictureBox();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.picResult3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.pic500big = new System.Windows.Forms.PictureBox();
            this.pic1000big = new System.Windows.Forms.PictureBox();
            this.pic2500big = new System.Windows.Forms.PictureBox();
            this.pic5000big = new System.Windows.Forms.PictureBox();
            this.pic5000small = new System.Windows.Forms.PictureBox();
            this.pic2500small = new System.Windows.Forms.PictureBox();
            this.pic1000small = new System.Windows.Forms.PictureBox();
            this.pic500small = new System.Windows.Forms.PictureBox();
            this.btnSmallAllin = new System.Windows.Forms.Button();
            this.btnBigAllin = new System.Windows.Forms.Button();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic500big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1000big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2500big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5000big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5000small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2500small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1000small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic500small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "(11 - 18)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(955, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "(3 - 10)";
            // 
            // txtBig
            // 
            this.txtBig.Font = new System.Drawing.Font("Kh BL BrushHand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBig.Location = new System.Drawing.Point(125, 338);
            this.txtBig.Name = "txtBig";
            this.txtBig.Size = new System.Drawing.Size(229, 57);
            this.txtBig.TabIndex = 6;
            this.txtBig.Text = "0";
            this.txtBig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBig.TextChanged += new System.EventHandler(this.txtBig_TextChanged);
            // 
            // txtSmall
            // 
            this.txtSmall.Font = new System.Drawing.Font("Kh BL BrushHand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmall.Location = new System.Drawing.Point(891, 338);
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.Size = new System.Drawing.Size(250, 57);
            this.txtSmall.TabIndex = 8;
            this.txtSmall.Text = "0";
            this.txtSmall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSmall.TextChanged += new System.EventHandler(this.txtSmall_TextChanged);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet.Font = new System.Drawing.Font("Kh BL BrushHand", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(499, 470);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(256, 80);
            this.btnBet.TabIndex = 9;
            this.btnBet.Text = "ចាក់";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kh BL BrushHand", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 68);
            this.label4.TabIndex = 13;
            this.label4.Text = "លុយ ៖";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(207, 15);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(174, 59);
            this.lblMoney.TabIndex = 14;
            this.lblMoney.Text = "10,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 59);
            this.label2.TabIndex = 15;
            this.label2.Text = "៛";
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.Location = new System.Drawing.Point(484, 10);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(41, 59);
            this.lblSign.TabIndex = 16;
            this.lblSign.Text = "+";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(573, 15);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(174, 59);
            this.lblPlus.TabIndex = 17;
            this.lblPlus.Text = "10,000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 59);
            this.label7.TabIndex = 18;
            this.label7.Text = "៛";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Kh BL BrushHand", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 108);
            this.label5.TabIndex = 19;
            this.label5.Text = "លទ្ធផល ៖";
            // 
            // btnBFromBank
            // 
            this.btnBFromBank.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBFromBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBFromBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBFromBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFromBank.Font = new System.Drawing.Font("Kh BL BrushHand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFromBank.Location = new System.Drawing.Point(883, 10);
            this.btnBFromBank.Name = "btnBFromBank";
            this.btnBFromBank.Size = new System.Drawing.Size(176, 82);
            this.btnBFromBank.TabIndex = 20;
            this.btnBFromBank.Text = "ខ្ចីលុយធនាគារ";
            this.btnBFromBank.UseVisualStyleBackColor = false;
            this.btnBFromBank.Click += new System.EventHandler(this.btnBFromBank_Click);
            // 
            // lblConditionWL
            // 
            this.lblConditionWL.AutoSize = true;
            this.lblConditionWL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConditionWL.Font = new System.Drawing.Font("Kh BL BrushHand", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionWL.Location = new System.Drawing.Point(521, 297);
            this.lblConditionWL.Name = "lblConditionWL";
            this.lblConditionWL.Size = new System.Drawing.Size(218, 108);
            this.lblConditionWL.TabIndex = 21;
            this.lblConditionWL.Text = "អ្នកឈ្នះ!";
            this.lblConditionWL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kh BL BrushHand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 676);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 55);
            this.label6.TabIndex = 22;
            this.label6.Text = "លុយជំពាក់ ៖";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(204, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 59);
            this.label8.TabIndex = 24;
            this.label8.Text = "៛";
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBorrow.Location = new System.Drawing.Point(251, 668);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(109, 59);
            this.lblBorrow.TabIndex = 23;
            this.lblBorrow.Text = "00.00";
            // 
            // picResult1
            // 
            this.picResult1.Image = ((System.Drawing.Image)(resources.GetObject("picResult1.Image")));
            this.picResult1.Location = new System.Drawing.Point(507, 206);
            this.picResult1.Name = "picResult1";
            this.picResult1.Size = new System.Drawing.Size(86, 88);
            this.picResult1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult1.TabIndex = 27;
            this.picResult1.TabStop = false;
            // 
            // picResult2
            // 
            this.picResult2.Image = ((System.Drawing.Image)(resources.GetObject("picResult2.Image")));
            this.picResult2.Location = new System.Drawing.Point(594, 206);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(86, 88);
            this.picResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult2.TabIndex = 28;
            this.picResult2.TabStop = false;
            // 
            // picResult3
            // 
            this.picResult3.Image = ((System.Drawing.Image)(resources.GetObject("picResult3.Image")));
            this.picResult3.Location = new System.Drawing.Point(680, 206);
            this.picResult3.Name = "picResult3";
            this.picResult3.Size = new System.Drawing.Size(86, 88);
            this.picResult3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult3.TabIndex = 29;
            this.picResult3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kh BL BrushHand", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 216);
            this.label9.TabIndex = 30;
            this.label9.Text = "ធំ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kh BL BrushHand", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(900, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 216);
            this.label10.TabIndex = 31;
            this.label10.Text = "តូច";
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefund.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Kh BL BrushHand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(1076, 10);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefund.Size = new System.Drawing.Size(176, 82);
            this.btnRefund.TabIndex = 32;
            this.btnRefund.Text = "សងលុយធនាគារ";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // pic500big
            // 
            this.pic500big.BackColor = System.Drawing.SystemColors.Control;
            this.pic500big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic500big.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic500big.Image = ((System.Drawing.Image)(resources.GetObject("pic500big.Image")));
            this.pic500big.Location = new System.Drawing.Point(120, 406);
            this.pic500big.Margin = new System.Windows.Forms.Padding(8);
            this.pic500big.Name = "pic500big";
            this.pic500big.Size = new System.Drawing.Size(102, 103);
            this.pic500big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic500big.TabIndex = 33;
            this.pic500big.TabStop = false;
            this.pic500big.Click += new System.EventHandler(this.pic500big_Click);
            this.pic500big.MouseLeave += new System.EventHandler(this.pic500big_MouseLeave);
            this.pic500big.MouseHover += new System.EventHandler(this.pic500big_MouseHover);
            // 
            // pic1000big
            // 
            this.pic1000big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1000big.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1000big.Image = ((System.Drawing.Image)(resources.GetObject("pic1000big.Image")));
            this.pic1000big.Location = new System.Drawing.Point(258, 406);
            this.pic1000big.Margin = new System.Windows.Forms.Padding(8);
            this.pic1000big.Name = "pic1000big";
            this.pic1000big.Size = new System.Drawing.Size(102, 103);
            this.pic1000big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1000big.TabIndex = 34;
            this.pic1000big.TabStop = false;
            this.pic1000big.Click += new System.EventHandler(this.pic1000big_Click);
            this.pic1000big.MouseLeave += new System.EventHandler(this.pic1000big_MouseLeave);
            this.pic1000big.MouseHover += new System.EventHandler(this.pic1000big_MouseHover);
            // 
            // pic2500big
            // 
            this.pic2500big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2500big.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2500big.Image = ((System.Drawing.Image)(resources.GetObject("pic2500big.Image")));
            this.pic2500big.Location = new System.Drawing.Point(120, 525);
            this.pic2500big.Margin = new System.Windows.Forms.Padding(8);
            this.pic2500big.Name = "pic2500big";
            this.pic2500big.Size = new System.Drawing.Size(102, 103);
            this.pic2500big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2500big.TabIndex = 35;
            this.pic2500big.TabStop = false;
            this.pic2500big.Click += new System.EventHandler(this.pic2500big_Click);
            this.pic2500big.MouseLeave += new System.EventHandler(this.pic2500big_MouseLeave);
            this.pic2500big.MouseHover += new System.EventHandler(this.pic2500big_MouseHover);
            // 
            // pic5000big
            // 
            this.pic5000big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic5000big.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic5000big.Image = ((System.Drawing.Image)(resources.GetObject("pic5000big.Image")));
            this.pic5000big.Location = new System.Drawing.Point(258, 525);
            this.pic5000big.Margin = new System.Windows.Forms.Padding(8);
            this.pic5000big.Name = "pic5000big";
            this.pic5000big.Size = new System.Drawing.Size(102, 103);
            this.pic5000big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5000big.TabIndex = 36;
            this.pic5000big.TabStop = false;
            this.pic5000big.Click += new System.EventHandler(this.pic5000big_Click);
            this.pic5000big.MouseLeave += new System.EventHandler(this.pic5000big_MouseLeave);
            this.pic5000big.MouseHover += new System.EventHandler(this.pic5000big_MouseHover);
            // 
            // pic5000small
            // 
            this.pic5000small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic5000small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic5000small.Image = ((System.Drawing.Image)(resources.GetObject("pic5000small.Image")));
            this.pic5000small.Location = new System.Drawing.Point(1039, 525);
            this.pic5000small.Margin = new System.Windows.Forms.Padding(8);
            this.pic5000small.Name = "pic5000small";
            this.pic5000small.Size = new System.Drawing.Size(102, 103);
            this.pic5000small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5000small.TabIndex = 40;
            this.pic5000small.TabStop = false;
            this.pic5000small.Click += new System.EventHandler(this.pic5000small_Click);
            this.pic5000small.MouseLeave += new System.EventHandler(this.pic5000small_MouseLeave);
            this.pic5000small.MouseHover += new System.EventHandler(this.pic5000small_MouseHover);
            // 
            // pic2500small
            // 
            this.pic2500small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2500small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2500small.Image = ((System.Drawing.Image)(resources.GetObject("pic2500small.Image")));
            this.pic2500small.Location = new System.Drawing.Point(901, 525);
            this.pic2500small.Margin = new System.Windows.Forms.Padding(8);
            this.pic2500small.Name = "pic2500small";
            this.pic2500small.Size = new System.Drawing.Size(102, 103);
            this.pic2500small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2500small.TabIndex = 39;
            this.pic2500small.TabStop = false;
            this.pic2500small.Click += new System.EventHandler(this.pic2500small_Click);
            this.pic2500small.MouseLeave += new System.EventHandler(this.pic2500small_MouseLeave);
            this.pic2500small.MouseHover += new System.EventHandler(this.pic2500small_MouseHover);
            // 
            // pic1000small
            // 
            this.pic1000small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1000small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1000small.Image = ((System.Drawing.Image)(resources.GetObject("pic1000small.Image")));
            this.pic1000small.Location = new System.Drawing.Point(1039, 406);
            this.pic1000small.Margin = new System.Windows.Forms.Padding(8);
            this.pic1000small.Name = "pic1000small";
            this.pic1000small.Size = new System.Drawing.Size(102, 103);
            this.pic1000small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1000small.TabIndex = 38;
            this.pic1000small.TabStop = false;
            this.pic1000small.Click += new System.EventHandler(this.pic1000small_Click);
            this.pic1000small.MouseLeave += new System.EventHandler(this.pic1000small_MouseLeave);
            this.pic1000small.MouseHover += new System.EventHandler(this.pic1000small_MouseHover);
            // 
            // pic500small
            // 
            this.pic500small.BackColor = System.Drawing.SystemColors.Control;
            this.pic500small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic500small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic500small.Image = ((System.Drawing.Image)(resources.GetObject("pic500small.Image")));
            this.pic500small.Location = new System.Drawing.Point(901, 406);
            this.pic500small.Margin = new System.Windows.Forms.Padding(8);
            this.pic500small.Name = "pic500small";
            this.pic500small.Size = new System.Drawing.Size(102, 103);
            this.pic500small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic500small.TabIndex = 37;
            this.pic500small.TabStop = false;
            this.pic500small.Click += new System.EventHandler(this.pic500small_Click);
            this.pic500small.MouseLeave += new System.EventHandler(this.pic500small_MouseLeave);
            this.pic500small.MouseHover += new System.EventHandler(this.pic500small_MouseHover);
            // 
            // btnSmallAllin
            // 
            this.btnSmallAllin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSmallAllin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSmallAllin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSmallAllin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmallAllin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallAllin.Location = new System.Drawing.Point(1171, 429);
            this.btnSmallAllin.Name = "btnSmallAllin";
            this.btnSmallAllin.Size = new System.Drawing.Size(81, 167);
            this.btnSmallAllin.TabIndex = 41;
            this.btnSmallAllin.Text = "All In";
            this.btnSmallAllin.UseVisualStyleBackColor = false;
            this.btnSmallAllin.Click += new System.EventHandler(this.btnSmallAllin_Click);
            // 
            // btnBigAllin
            // 
            this.btnBigAllin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBigAllin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBigAllin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBigAllin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBigAllin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBigAllin.Location = new System.Drawing.Point(14, 429);
            this.btnBigAllin.Name = "btnBigAllin";
            this.btnBigAllin.Size = new System.Drawing.Size(81, 167);
            this.btnBigAllin.TabIndex = 42;
            this.btnBigAllin.Text = "All In";
            this.btnBigAllin.UseVisualStyleBackColor = false;
            this.btnBigAllin.Click += new System.EventHandler(this.btnBigAllin_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit.Image")));
            this.pictureExit.Location = new System.Drawing.Point(1171, 657);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(81, 69);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 44;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            this.pictureExit.MouseLeave += new System.EventHandler(this.pictureExit_MouseLeave);
            this.pictureExit.MouseHover += new System.EventHandler(this.pictureExit_MouseHover);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnBet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 738);
            this.Controls.Add(this.btnBigAllin);
            this.Controls.Add(this.btnSmallAllin);
            this.Controls.Add(this.pictureExit);
            this.Controls.Add(this.pic5000small);
            this.Controls.Add(this.pic2500small);
            this.Controls.Add(this.pic1000small);
            this.Controls.Add(this.pic500small);
            this.Controls.Add(this.pic5000big);
            this.Controls.Add(this.pic2500big);
            this.Controls.Add(this.pic1000big);
            this.Controls.Add(this.pic500big);
            this.Controls.Add(this.btnBFromBank);
            this.Controls.Add(this.txtSmall);
            this.Controls.Add(this.txtBig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picResult3);
            this.Controls.Add(this.picResult2);
            this.Controls.Add(this.picResult1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBorrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblConditionWL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBet);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big and Small Game v1.0";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic500big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1000big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2500big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5000big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5000small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2500small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1000small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic500small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBig;
        private System.Windows.Forms.TextBox txtSmall;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBFromBank;
        private System.Windows.Forms.Label lblConditionWL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.PictureBox picResult1;
        private System.Windows.Forms.PictureBox picResult2;
        private System.Windows.Forms.PictureBox picResult3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.PictureBox pic500big;
        private System.Windows.Forms.PictureBox pic1000big;
        private System.Windows.Forms.PictureBox pic2500big;
        private System.Windows.Forms.PictureBox pic5000big;
        private System.Windows.Forms.PictureBox pic5000small;
        private System.Windows.Forms.PictureBox pic2500small;
        private System.Windows.Forms.PictureBox pic1000small;
        private System.Windows.Forms.PictureBox pic500small;
        private System.Windows.Forms.Button btnSmallAllin;
        private System.Windows.Forms.Button btnBigAllin;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}

