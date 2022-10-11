namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();

        }

        private bool Balioak()
        {
            bool error = false;
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(txtZenbaki1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(txtZenbaki2.Text);
            }
            catch(Exception ex) 
            {
                error = true;
                MessageBox.Show("errorea gertatu da:" + ex.Message);
                
            }
            return error;

        }

        private void hasieratu()
        {
            txtZenbaki1.Text = "";
            txtZenbaki2.Text = "";

            txtZenbaki1.Focus();
        }

        private void btnGehiketa_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
                hasieratu();    
            }
            
            
        }

        private void btnKenketa_Click(object sender, EventArgs e)
        {
            if (Balioak())
            { 
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                hasieratu();
            }
               
           
        }

        private void btnBiderketa_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
                hasieratu();
            }
            
        }

        private void btnZatiketa_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
                hasieratu();
            }
            
        }

        private void txtZenbaki1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }

        }
        private void txtZenbaki2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }

        }

        
    }
}