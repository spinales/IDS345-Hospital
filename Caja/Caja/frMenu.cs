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
    public partial class frMenu : Form
    {
        private Persona persona;

        public frMenu(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
        }


        private Form formActivo = null; //variable para activar y desactivar los formularios, se le da un valor inicial nulo
        public void abrirSubFormulario(Form formHijo) // metodo para abrir y cerrar los formularios hijos dentro del principal
        {
            if (formActivo != null) // si hay un formulario abierto, sea cual sea, que se cierre
                formActivo.Close();
            formActivo = formHijo; // el form que este activo sera igual al form hijo
            formHijo.TopLevel = false; // el forms no se abrira encima del tope del principal
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // el forms rellenara todo el espacio del panel
            panelFormHijo.Controls.Add(formHijo); // el form hijo se abrira especificamente en este panel
            panelFormHijo.Tag = formHijo;
            formHijo.Show();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cuadrebtn_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new frCuadre());

        }

        private void Facturabtn_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new frFacturacion(persona));


        }

        private void Cuentabtn_Click(object sender, EventArgs e)
        {
            abrirSubFormulario(new frCuenta());

        }
    }
}
