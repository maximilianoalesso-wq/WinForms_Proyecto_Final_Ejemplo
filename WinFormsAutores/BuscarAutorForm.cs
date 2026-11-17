using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAutores
{
    public partial class BuscarAutorForm : Form
    {
        private List<Autor> autores;
        public int IdAutorSeleccionado { get; set; } = -1; //inicializamos con un valor invalido
        public BuscarAutorForm()
        {
            InitializeComponent();
        }

        private async void BuscarAutorForm_Load(object sender, EventArgs e)
        {
            using HttpClient cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imxkc3pveGttd3N0Z3ZhcmdvcmttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzYxOTA3MTYsImV4cCI6MjA5MTc2NjcxNn0.cqjbbUQ7dRKOz6dKKYTXzdEuySXpqEGRhiW4ZrqdPao");
            var respuesta = await cliente.GetAsync("https://ldszoxkmwstgvargorkm.supabase.co/rest/v1/autor");
            if (respuesta.IsSuccessStatusCode == true)
            {
                autores = await respuesta.Content.ReadFromJsonAsync<List<Autor>>();
                grillaAutores.DataSource = autores;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //esta linea ya me cierra el formulario
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grillaAutores.CurrentRow.Index < 0)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return; //salir del metodo
            }

            IdAutorSeleccionado = int.Parse(grillaAutores.CurrentRow.Cells["ColId"].Value.ToString());
            DialogResult = DialogResult.OK;

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            List<Autor> listaFiltrada = autores.Where(a => a.nombre.ToLower().Contains(txtBuscar.Text.Trim().ToLower())).ToList();
            grillaAutores.DataSource = listaFiltrada;
        }
    }
}

