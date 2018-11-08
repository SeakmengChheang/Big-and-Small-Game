using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_and_Small
{
    public partial class frmMain : Form
    {
        private static CancellationTokenSource tokenSource = new CancellationTokenSource();
        private static bool runFirstTime = true;
        private static string FolderPath = Environment.CurrentDirectory;
        private static Random r = new Random();
        private static decimal money = 10000;
        private static decimal borrow = 0;
        private static decimal big = 0;
        private static decimal small = 0;
        private static Thread t = new Thread(() => SplashForm());

        private static void SplashForm()
        {
            Application.Run(new frmSplashScreen());
        }

        public frmMain()
        {
            InitializeComponent();
            if (runFirstTime)
            {
                t.Start();
                runFirstTime = false;
                Thread.Sleep(3000);
            }

        }

        /// <summary>
        /// Sound play
        /// </summary>
        private static void dicesound()
        {
            Stream str = Properties.Resources.dice;
            SoundPlayer sound = new SoundPlayer(str);
            sound.Play();
        }

        private static async Task startSound()
        {
            Stream str = Properties.Resources.start;
            SoundPlayer sound = new SoundPlayer(str);
            sound.Play();
            await Task.Delay(500, tokenSource.Token);
        }

        #region Encrypt Money

        private static string encrypt(decimal number)
        {
            string sNumber = number.ToString();
            int[] temp = new int[sNumber.Length];
            for (int i = 0; i < sNumber.Length; i++)
                temp[i] = int.Parse(sNumber[i].ToString());

            StringBuilder sendToFile = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] += i + 1;
                sendToFile.Append(translateNumtoChar(temp[i]));
            }
            return sendToFile.ToString();
        }

        private static decimal decrypt(string numberString)
        {
            int[] arrayTemp = new int[numberString.Length];
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < numberString.Length; i++)
            {
                arrayTemp[i] = translateChartoNum(numberString[i]);
                arrayTemp[i] -= i + 1;
                sbuilder.Append(arrayTemp[i].ToString());
            }

            decimal deBack = decimal.Parse(sbuilder.ToString());
            return deBack;
        }

        private static int translateChartoNum(char character)
        {
            switch (character)
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
                case 'i': return 8;
                case 'j': return 9;
                case 'k': return 10;
                case 'l': return 11;
                case 'm': return 12;
                case 'n': return 13;
                case 'o': return 14;
                case 'p': return 15;
                case 'q': return 16;
                case 'r': return 17;
                case 's': return 18;
                case 't': return 19;
                case 'u': return 20;
                case 'v': return 21;
                case 'w': return 22;
                case 'x': return 23;
                case 'y': return 24;
                case 'z': return 25;
            }
            return 0;
        }

        private static char translateNumtoChar(int number)
        {
            switch (number)
            {
                case 0: return 'a';
                case 1: return 'b';
                case 2: return 'c';
                case 3: return 'd';
                case 4: return 'e';
                case 5: return 'f';
                case 6: return 'g';
                case 7: return 'h';
                case 8: return 'i';
                case 9: return 'j';
                case 10: return 'k';
                case 11: return 'l';
                case 12: return 'm';
                case 13: return 'n';
                case 14: return 'o';
                case 15: return 'p';
                case 16: return 'q';
                case 17: return 'r';
                case 18: return 's';
                case 19: return 't';
                case 20: return 'u';
                case 21: return 'v';
                case 22: return 'w';
                case 23: return 'x';
                case 24: return 'y';
                case 25: return 'z';
            }
            return ' ';
        }

        #endregion Encrypt Money

        #region load image from files

        private static async Task loadImage(int result, PictureBox namePicBox, int timeWaiting = 0)
        {
            await Task.Delay(timeWaiting * 1000, tokenSource.Token);
            try
            {
                switch (result)
                {
                    case 1:
                        namePicBox.Image = Properties.Resources._1;
                        break;

                    case 2:
                        namePicBox.Image = Properties.Resources._2;
                        break;

                    case 3:
                        namePicBox.Image = Properties.Resources._3;
                        break;

                    case 4:
                        namePicBox.Image = Properties.Resources._4;
                        break;

                    case 5:
                        namePicBox.Image = Properties.Resources._5;
                        break;

                    case 6:
                        namePicBox.Image = Properties.Resources._6;
                        break;
                }
            }
            catch (Exception) { MessageBox.Show("No Image data to show!"); };
            //await Task.Delay(timeWaiting * 1000, tokenSource.Token);
        }

        private static void animationImage(PictureBox namePicBox)
        {
            int random = r.Next(2) + 1;
            if (random == 1)
                namePicBox.Image = Properties.Resources.a1;
            else
                namePicBox.Image = Properties.Resources.a2;
            //await Task.Delay(time * 1000, tokenSource.Token);
        }

        #endregion load image from files

        private async void btnBet_Click(object sender, EventArgs e)
        {
            if (txtBig.Text == "")
                txtBig.Text = "0";
            else if (txtSmall.Text == "")
                txtSmall.Text = "0";
            try
            {
                big = decimal.Parse(txtBig.Text);
                small = decimal.Parse(txtSmall.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("សូមបញ្ចូលលេខឲ្យបានត្រឹមត្រូវ។");
                txtBig.Focus();
                txtBig.SelectAll();
                return;
            }

            //use tempMoney to find USER win or lose
            decimal tempMoney = money;

            //if negative amount of money is input
            if (big < 0 || small < 0)
            {
                MessageBox.Show("ចំនួនចាក់មិនអាចតូចជាង 0 បានទេ។");
                txtBig.Focus();
                txtBig.SelectAll();
                return;
            }
            //if nothing is input
            if (big == 0 && small == 0)
            {
                MessageBox.Show("សូមដាក់លុយសិនមុនពេលចុច \"ចាក់\"");
                txtBig.Focus();
                txtBig.SelectAll();
                return;
            }
            //if amount of bet bigger than money
            if (money < big + small)
            {
                MessageBox.Show("លុយមិនគ្រប់គ្រាន់ក្នុងការភ្នាល់!");
                if (big > 0)
                {
                    txtBig.Focus();
                    txtBig.SelectAll();
                }
                else
                {
                    txtSmall.Focus();
                    txtSmall.SelectAll();
                }
                return;
            }

            await startSound();
            lblConditionWL.Text = "";
            btnBet.Enabled = false;
            btnBFromBank.Enabled = false;
            btnRefund.Enabled = false;
            btnBigAllin.Enabled = false;
            btnSmallAllin.Enabled = false;
            dicesound();

            animationImage(picResult1);
            animationImage(picResult2);
            animationImage(picResult3);

            int r1 = r.Next(6) + 1;
            int r2 = r.Next(6) + 1;
            int r3 = r.Next(6) + 1;
            await loadImage(r1, picResult1, 1);
            await loadImage(r2, picResult2, 2);
            await loadImage(r3, picResult3, 2);

            int result = r1 + r2 + r3;
            bool rsIsBig, rsIsSmall;
            rsIsBig = rsIsSmall = false;
            if (result > 10)
                rsIsBig = true;
            else
                rsIsSmall = true;

            if (rsIsBig)
            {
                if (big > 0)
                    money += big;
                if (small > 0)
                    money -= small;
            }
            else if (rsIsSmall)
            {
                if (small > 0)
                    money += small;
                if (big > 0)
                    money -= big;
            }

            Thread.Sleep(100);
            lblMoney.Text = money.ToString("#,##0.00");
            decimal findWL = money - tempMoney;
            if (findWL > 0)
            {
                lblSign.Text = "+";
                lblPlus.Text = findWL.ToString("#,##0.00");
                lblConditionWL.Text = "អ្នកឈ្នះ!";
            }
            else
            {
                lblSign.Text = "-";
                lblPlus.Text = Math.Abs(findWL).ToString("#,##0.00");
                lblConditionWL.Text = "អ្នកចាញ់!";
            }

            #region Enable all buttons and clear text

            txtBig.Text = "0";
            txtSmall.Text = "0";
            big = 0; small = 0;
            txtBig.Focus();
            txtBig.SelectAll();
            btnBet.Enabled = true;
            btnBFromBank.Enabled = true;
            btnRefund.Enabled = true;
            btnSmallAllin.Enabled = true;
            btnBigAllin.Enabled = true;
            btnBigAllin.Enabled = true;
            btnSmallAllin.Enabled = true;

            #endregion Enable all buttons and clear text
        }

        private void btnBFromBank_Click(object sender, EventArgs e)
        {
            int decision = r.Next(100) + 1;
            if (decision >= 35)
            {
                int lentMoney = r.Next(50000) + 1;
                MessageBox.Show($"៛ {lentMoney.ToString("#,##0.00")} has been decided to lend to you.");
                money += lentMoney;
                borrow += lentMoney;
                lblMoney.Text = money.ToString("#,##0.00");
                lblBorrow.Text = borrow.ToString("#,##0.00");
                lblSign.Text = "+";
                lblPlus.Text = lentMoney.ToString("#,##0.00");
            }
            else
            {
                MessageBox.Show("Base on your profile, Banker has decided to reject your request. \nTry again next time!");
            }
        }

        private static bool backFromRefund = false;

        private void btnRefund_Click(object sender, EventArgs e)
        {
            backFromRefund = true;
            new Refund().ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            t.Abort();
            this.TopMost = true;
            if (backFromRefund)
            {
                decimal pastBorrow = decimal.Parse(lblBorrow.Text);
                decimal nowBorrow = pastBorrow - borrow;
                lblSign.Text = "-";
                lblPlus.Text = Math.Abs(nowBorrow).ToString("#,##0.00");
                backFromRefund = false;
            }

            lblMoney.Text = money.ToString("#,##0.00");
            lblBorrow.Text = borrow.ToString("#,##0.00");
            this.TopMost = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblSign.Text = "+";
            lblPlus.Text = "00.00";
            lblConditionWL.Text = "";
            using (StreamReader sr = new StreamReader(FolderPath + "\\Datas.txt"))
            {
                money = decrypt(sr.ReadLine());
                borrow = decrypt(sr.ReadLine());
                //money = decimal.Parse(sr.ReadLine());
                //borrow = decimal.Parse(sr.ReadLine());
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(FolderPath + "\\Datas.txt"))
            {
                sw.WriteLine(encrypt(money));
                sw.WriteLine(encrypt(borrow));
                //sw.WriteLine(money.ToString());
                //sw.WriteLine(borrow.ToString());
            }
        }

        #region Update the BIG coin when clicked in term of VALUE

        private void bigCoinUpdate(int coinValue)
        {
            big += coinValue;
            txtBig.Text = big.ToString();
            txtBig.Focus();
            txtBig.SelectAll();
        }

        private void pic500big_Click(object sender, EventArgs e)
        {
            bigCoinUpdate(500);
        }

        private void pic1000big_Click(object sender, EventArgs e)
        {
            bigCoinUpdate(1000);
        }

        private void pic2500big_Click(object sender, EventArgs e)
        {
            bigCoinUpdate(2500);
        }

        private void pic5000big_Click(object sender, EventArgs e)
        {
            bigCoinUpdate(5000);
        }

        #endregion Update the BIG coin when clicked  in term of VALUE

        #region Update the SMALL coin when clicked in term of VALUE

        private void smallCoinUpdate(int coinValue)
        {
            small += coinValue;
            txtSmall.Text = small.ToString();
            txtSmall.Focus();
            txtSmall.SelectAll();
        }

        private void pic500small_Click(object sender, EventArgs e)
        {
            smallCoinUpdate(500);
        }

        private void pic1000small_Click(object sender, EventArgs e)
        {
            smallCoinUpdate(1000);
        }

        private void pic2500small_Click(object sender, EventArgs e)
        {
            smallCoinUpdate(2500);
        }

        private void pic5000small_Click(object sender, EventArgs e)
        {
            smallCoinUpdate(5000);
        }

        #endregion Update the SMALL coin when clicked in term of VALUE

        #region Update to BIG & SMALL variable if there any value change

        private void txtBig_TextChanged(object sender, EventArgs e)
        {
            big = 0;
            btnBigAllin.Enabled = true;
            btnSmallAllin.Enabled = true;
            try
            {
                big = decimal.Parse(txtBig.Text);
            }
            catch (Exception) { }
        }

        private void txtSmall_TextChanged(object sender, EventArgs e)
        {
            small = 0;
            btnBigAllin.Enabled = true;
            btnSmallAllin.Enabled = true;
            try
            {
                small = decimal.Parse(txtSmall.Text);
            }
            catch (Exception) { }
        }

        #endregion Update to BIG & SMALL variable if there any value change

        private void btnSmallAllin_Click(object sender, EventArgs e)
        {
            txtSmall.Text = money.ToString();
            btnBigAllin.Enabled = false;
            btnSmallAllin.Enabled = false;
            txtSmall.Focus();
            txtSmall.SelectAll();
        }

        private void btnBigAllin_Click(object sender, EventArgs e)
        {
            txtBig.Text = money.ToString();
            btnSmallAllin.Enabled = false;
            btnBigAllin.Enabled = false;
            txtBig.Focus();
            txtBig.SelectAll();
        }

        #region Coin Hover and Leave
        private static void hoverBigger(PictureBox nameObject, int size)
        {
            nameObject.Width += size;
            nameObject.Height += size;
        }
        private static void leaveSmaller(PictureBox nameObject)
        {
            nameObject.Width = 102;
            nameObject.Height = 103;
        }

        private void pic500big_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic500big, 5);
        }

        private void pic500big_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic500big);
        }
        private void pic1000big_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic1000big, 5);
        }

        private void pic1000big_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic1000big);
        }
        private void pic2500big_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic2500big, 5);
        }

        private void pic2500big_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic2500big);
        }

        private void pic5000big_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic5000big, 5);
        }

        private void pic5000big_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic5000big);
        }
        private void pic500small_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic500small, 5);
        }

        private void pic500small_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic500small);
        }

        private void pic1000small_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic1000small, 5);
        }

        private void pic1000small_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic1000small);
        }

        private void pic2500small_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic2500small, 5);
        }

        private void pic2500small_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic2500small);
        }

        private void pic5000small_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pic5000small, 5);
        }

        private void pic5000small_MouseLeave(object sender, EventArgs e)
        {
            leaveSmaller(pic5000small);
        }

        private void pictureExit_MouseHover(object sender, EventArgs e)
        {
            hoverBigger(pictureExit, 10);
            pictureExit.BackColor = Color.SkyBlue;
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            pictureExit.Width = 81;
            pictureExit.Height = 69;
            pictureExit.BackColor = Color.Transparent;
        }
        #endregion

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #region Method to interact with Refund.cs
        public decimal getMoney
        {
            get
            {
                return money;
            }
        }

        public decimal getBorrowMoney
        {
            get
            {
                return borrow;
            }
        }

        public decimal setMoney
        {
            set
            {
                money = value;
            }
        }

        public decimal setBorrowMoney
        {
            set
            {
                borrow = value;
            }
        }
        #endregion

    }
}