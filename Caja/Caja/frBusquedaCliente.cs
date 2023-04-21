using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frBusquedaCliente : Form
    {
        private Persona cliente;
        public frBusquedaCliente(Persona cliente)
        {
            InitializeComponent();
            txtbClienteDocumento.Text = cliente.Documento;
            txtbClienteNombre.Text = cliente.Nombre;
            txtbClienteApellido.Text = cliente.Apellido;
            txtbTelefono.Text = cliente.Telefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
