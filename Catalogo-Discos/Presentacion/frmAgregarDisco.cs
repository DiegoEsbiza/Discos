using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmAgregarDisco : Form
    {       
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            EstilosNegocio estiloNegocio = new EstilosNegocio();
            TiposEdicionNegocio tiposEdicionNegocio = new TiposEdicionNegocio();

            try
            {
                cboEstilos.DataSource = estiloNegocio.Listar();
                cboEstilos.ValueMember = "Id";
                cboEstilos.DisplayMember = "Descripcion";
                cboFormatoEdicion.DataSource = tiposEdicionNegocio.Listar();
                cboFormatoEdicion.ValueMember = "Id";
                cboFormatoEdicion.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos disco = new Discos();
            try
            {
                disco.titulo = txtTitulo.Text;
                disco.fechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.cantidadCanciones = (int)numCantidadCanciones.Value;
                disco.estilos = (Estilos)cboEstilos.SelectedItem;
                disco.tipoEdicion = (TiposEdicion)cboFormatoEdicion.SelectedItem;
                disco.urlImagenTapa = txtUrlImagen.Text;

                negocio.Agregar(disco);
                MessageBox.Show("¡Disco agregado exitosamente!");

                DialogResult respuesta = MessageBox.Show("¿Deseea agregar un nuevo disco?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {                   
                    txtTitulo.Text = "";
                    dtpFechaLanzamiento.Value = DateTime.Now;
                    numCantidadCanciones.Value = 0;
                    cboEstilos.ValueMember = "Id";
                    cboEstilos.DisplayMember = "Descripcion";
                    cboFormatoEdicion.ValueMember = "Id";
                    cboFormatoEdicion.DisplayMember = "Descripcion";
                    txtUrlImagen.Text = "";
                    CargarImagen(txtUrlImagen.Text);

                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxImagenTapa.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenTapa.Load("https://img.freepik.com/premium-vector/photo-icon-picture-icon-image-sign-symbol-vector-illustration_64749-4409.jpg");
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }
    }
}
