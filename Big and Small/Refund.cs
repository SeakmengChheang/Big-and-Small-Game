using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_and_Small
{
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
        }
        static frmMain obj = new frmMain();
        static double moneyRemain = obj.getMoney;
        static double borrowMoney = obj.getBorrowMoney;
        private void btnRefund_Click(object sender, EventArgs e)
        {
            double refundMoney = double.Parse(txtMoneyRefund.Text);
            if(refundMoney > borrowMoney)
            {
                MessageBox.Show("អ្នកមិនអាចសងលើសចំនួនជំពាក់បានទេ។");
                txtMoneyRefund.SelectAll();
                return;
            }
            if(refundMoney > moneyRemain)
            {
                MessageBox.Show("អ្នកមិនអាចសងលើសចំនួនលុយនៅសល់បានទេ។");
                txtMoneyRefund.SelectAll();
                return;
            }

            moneyRemain -= refundMoney;
            borrowMoney -= refundMoney;
            obj.setMoney       = moneyRemain;
            obj.setBorrowMoney = borrowMoney;
            MessageBox.Show($"លុយចំនួន ៛{refundMoney.ToString("#,##0.00")} ត្រូវបានសង។​ \nលុយអ្នកនៅសល់ចំនួន ៛{moneyRemain.ToString("#,##0.00")}");
            
            this.Close();
        }

        private void txtMoneyRefund_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double refund = double.Parse(txtMoneyRefund.Text);
                double remain = moneyRemain - refund;
                lblMoneyRemain.Text = remain.ToString("#,##0.00");
            }
            catch (Exception) { lblMoneyRemain.Text = "សូមបញ្ចូលលេខឲ្យបានត្រឹមត្រូវ។"; };
        }

        private void Refund_Activated(object sender, EventArgs e)
        {
            moneyRemain = obj.getMoney;
            borrowMoney = obj.getBorrowMoney;
        }
    }
}
