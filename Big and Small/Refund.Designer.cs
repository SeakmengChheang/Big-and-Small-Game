namespace Big_and_Small
{
    partial class Refund
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoneyRefund = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoneyRemain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kh BL BrushHand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 55);
            this.label4.TabIndex = 14;
            this.label4.Text = "ចំនួនសង ៖";
            // 
            // txtMoneyRefund
            // 
            this.txtMoneyRefund.Font = new System.Drawing.Font("Kh BL BrushHand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyRefund.Location = new System.Drawing.Point(259, 32);
            this.txtMoneyRefund.Name = "txtMoneyRefund";
            this.txtMoneyRefund.Size = new System.Drawing.Size(371, 57);
            this.txtMoneyRefund.TabIndex = 15;
            this.txtMoneyRefund.Text = "00.00";
            this.txtMoneyRefund.TextChanged += new System.EventHandler(this.txtMoneyRefund_TextChanged);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefund.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Kh BL BrushHand", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(204, 240);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(256, 75);
            this.btnRefund.TabIndex = 16;
            this.btnRefund.Text = "សង";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kh BL BrushHand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "លុយនៅសល់ ៖";
            // 
            // lblMoneyRemain
            // 
            this.lblMoneyRemain.AutoSize = true;
            this.lblMoneyRemain.Font = new System.Drawing.Font("Kh BL BrushHand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyRemain.Location = new System.Drawing.Point(249, 140);
            this.lblMoneyRemain.Name = "lblMoneyRemain";
            this.lblMoneyRemain.Size = new System.Drawing.Size(103, 55);
            this.lblMoneyRemain.TabIndex = 18;
            this.lblMoneyRemain.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 59);
            this.label3.TabIndex = 19;
            this.label3.Text = "៛";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kh BL BrushHand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 59);
            this.label5.TabIndex = 20;
            this.label5.Text = "៛";
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMoneyRemain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.txtMoneyRefund);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Refund";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Refund_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoneyRefund;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoneyRemain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}