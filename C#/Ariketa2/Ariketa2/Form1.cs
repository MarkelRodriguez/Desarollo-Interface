namespace Ariketa2
{
    public partial class Form1 : Form
    {
        
        Zenbakia zenbakia = new Zenbakia();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (this.labelZenbakia.Text.ToLower())
            {
                case "1.zenbakia":
                    zenbakia.a = (int)float.Parse(txtZenbakia.Text);
                    labelZenbakia.Text = "2.Zenbakia";
                    txtZenbakia.Text = "";
                    break;

                case "2.zenbakia":
                    zenbakia.b = (int)float.Parse(txtZenbakia.Text);
                    labelZenbakia.Text = "3.Zenbakia";
                    txtZenbakia.Text = "";
                    break;

                case "3.zenbakia":
                    zenbakia.c = (int)float.Parse(txtZenbakia.Text);
                    labelZenbakia.Text = "4.Zenbakia";
                    txtZenbakia.Text = "";
                    break;

                case "4.zenbakia":
                    zenbakia.d = (int)float.Parse(txtZenbakia.Text);
                    zenbakia.emaitza = zenbakia.Eragiketa();
                    txtZenbakia.Text = "(" + zenbakia.a + " + (2 X " + zenbakia.b + ") + (3 X " + zenbakia.c + ") + (4 X " + zenbakia.d + ")/4 = "+ zenbakia.emaitza;
                    
                    break;


            }
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            this.labelZenbakia.Text = "1.Zenbakia";
            this.txtZenbakia.Text = "";
            zenbakia.a = 0;
            zenbakia.b = 0;
            zenbakia.c = 0;
            zenbakia.d = 0;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtZenbakia_KeyPress(object sender, KeyPressEventArgs e) //Controlar que el usuario no pueda meter letras, solo números.
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
                    if (txtZenbakia.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbakia.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
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