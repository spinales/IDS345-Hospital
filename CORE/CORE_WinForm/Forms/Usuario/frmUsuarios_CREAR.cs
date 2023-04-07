using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public partial class frmUsuarios_CREAR : Form
    {
        public frmUsuarios_CREAR()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlamarApi();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //borrar campos de todos los text box
        }

        private  async void LlamarApi()
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "Username", txtUsuario.Text },
                    { "Password", txtContraseña.Text },
                    { "Email", txtCorreo.Text },
                    { "SucursalID", "1" },
                    { "PerfilID", "1" }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("https://localhost:44329/CORE/InsertarUsuario", content);
                

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("EXITOO");
                }
                else
                {
                    MessageBox.Show("bobo");
                }
            }

        }
    }
}
