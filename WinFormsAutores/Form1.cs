namespace WinFormsAutores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAutores_Click(object sender, EventArgs e)
        {
            //abrir formulario autores
            AutoresForm autoresForm = new AutoresForm();
            autoresForm.ShowDialog();
        }
    }
}
