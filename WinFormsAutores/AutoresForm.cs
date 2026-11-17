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
    public partial class AutoresForm : Form
    {
        private int idAutorActual;
        public AutoresForm()
        {
            InitializeComponent();
        }

        private void AutoresForm_Load(object sender, EventArgs e)
        {
            idAutorActual = 0; //inicializamos la variable de clase

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el autor");
                return;
            }
            if (idAutorActual == 0) //significa que es un nuevo autor
            {
                AutorDTO autor = new AutorDTO();
                autor.nombre = txtNombre.Text;
                autor.edad = int.Parse(txtEdad.Text);


                using HttpClient cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Add("apikey", "TU_API_KEY_SUPABASE.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imxkc3pveGttd3N0Z3ZhcmdvcmttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzYxOTA3MTYsImV4cCI6MjA5MTc2NjcxNn0.cqjbbUQ7dRKOz6dKKYTXzdEuySXpqEGRhiW4ZrqdPao");
                var httpRespuesta = await cliente.PostAsJsonAsync("https://TU_URL_SUPABASE.supabase.co/rest/v1/autor", autor);
                if (httpRespuesta.IsSuccessStatusCode == true)
                {
                    MessageBox.Show("Autor creado correctamente.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el autor.");

                }
            }
            else //autorActual.id != 0, significa que el dato se leyo de la base de datos asi que ya viene con un id distinto de cero
            {
                AutorDTO autor = new AutorDTO();
                autor.nombre = txtNombre.Text;
                autor.edad = int.Parse(txtEdad.Text);
                //autorActual.nombre = txtNombre.Text;
                //autorActual.edad = int.Parse(txtEdad.Text);


                using HttpClient cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Add("apikey", "TU_API_KEY_SUPABASE.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imxkc3pveGttd3N0Z3ZhcmdvcmttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzYxOTA3MTYsImV4cCI6MjA5MTc2NjcxNn0.cqjbbUQ7dRKOz6dKKYTXzdEuySXpqEGRhiW4ZrqdPao");
                var httpRespuesta = await cliente.PatchAsJsonAsync("https://TU_URL_SUPABASE.supabase.co/rest/v1/autor?id=eq." + idAutorActual, autor);
                if (httpRespuesta.IsSuccessStatusCode == true)
                {
                    MessageBox.Show("Autor se modifico correctamente.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar el autor.");

                }

            }

        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            idAutorActual = 0;
            txtNombre.Focus();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            BuscarAutorForm buscarAutorForm = new BuscarAutorForm();
            res = buscarAutorForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                idAutorActual = buscarAutorForm.IdAutorSeleccionado;

                using HttpClient cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Add("apikey", "TU_API_KEY_SUPABASE.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imxkc3pveGttd3N0Z3ZhcmdvcmttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzYxOTA3MTYsImV4cCI6MjA5MTc2NjcxNn0.cqjbbUQ7dRKOz6dKKYTXzdEuySXpqEGRhiW4ZrqdPao");
                var respuesta = await cliente.GetAsync("https://TU_URL_SUPABASE.supabase.co/rest/v1/autor?id=eq." + idAutorActual);
                if (respuesta.IsSuccessStatusCode == true)
                {
                    List<Autor> lista = await respuesta.Content.ReadFromJsonAsync<List<Autor>>();
                    Autor autorSeleccionado = lista[0];
                    txtNombre.Text = autorSeleccionado.nombre;
                    txtEdad.Text = autorSeleccionado.edad.ToString();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al recuperar el autor seleccionado.");
                }
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Esta seguro que desea eliminar al autor: " + txtNombre.Text + "?", "Autores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                using HttpClient cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Add("apikey", "TU_API_KEY_SUPABASE.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imxkc3pveGttd3N0Z3ZhcmdvcmttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzYxOTA3MTYsImV4cCI6MjA5MTc2NjcxNn0.cqjbbUQ7dRKOz6dKKYTXzdEuySXpqEGRhiW4ZrqdPao");
                var httpRespuesta = await cliente.DeleteAsync("https://TU_URL_SUPABASE.supabase.co/rest/v1/autor?id=eq." + idAutorActual);
                if (httpRespuesta.IsSuccessStatusCode == true)
                {
                    MessageBox.Show("Autor se elimino correctamente.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el autor.");

                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

        }
    }
}
