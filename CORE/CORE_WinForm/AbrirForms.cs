using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    internal class AbrirForms
    {
        public T AbrirFormulario<T>(Type buscarTipo) where T : Form, new()
        {
            var formBuscar = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formBuscar != null)
            {
                formBuscar.Activate();
                formBuscar.BringToFront();
                return formBuscar;
            }
            else
            {
                var formAbrir = new T();
                formAbrir.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                formAbrir.KeyPreview = true;
                formAbrir.Location = new System.Drawing.Point(300, 50);
                formAbrir.MaximizeBox = false;
                formAbrir.MinimizeBox = false;
                formAbrir.MinimumSize = new System.Drawing.Size(500, 500);
                formAbrir.ShowIcon = false;
                formAbrir.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                formAbrir.ShowDialog();
                return formAbrir;
            }
        }


    }
}
