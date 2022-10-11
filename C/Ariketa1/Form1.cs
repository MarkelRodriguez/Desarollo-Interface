namespace Ariketa1
{
    public partial class Form1 : Form
    {
        Esaldia esaldia = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
        }
        private String Esaldiak()
        {
            esaldia.Hitza = txtEsaldiak.Text;

            return esaldia.Lotu();
            
        }
        private void btnEsaldi1_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = true;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;

            Esaldiak();
            txtEsaldiak.Text = "";
        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = true;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
            Esaldiak();
            txtEsaldiak.Text = "";
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = true;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
            Esaldiak();
            txtEsaldiak.Text = "";
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = true;
            btnLotu.Enabled = false;
            Esaldiak();
            txtEsaldiak.Text = "";
        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = true;
            Esaldiak();
            txtEsaldiak.Text = "";

        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
             MessageBox.Show(Esaldiak());
            txtEsaldiak.Text = "";
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiBatua = "";
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
            txtEsaldiak.Focus();
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}