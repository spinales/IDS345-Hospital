using Caja.Migrations;
using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caja.DTOs.Views;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Newtonsoft.Json;

namespace Caja
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private async void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string contrasena = txtContraseñaLogin.Text;

            // Convertir la contraseña ingresada en hash
            string contrasenaHash = Validacion.HashPassword(contrasena);

            var httpClient = new HttpClient();
            var apiUrl = "https://localhost:44348/CAJA/login";
            var requestBody = new
            {
                Username = usuario,
                Password = contrasenaHash
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "Application/json");

            var response = await httpClient.PostAsync(apiUrl, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            

            if (response.IsSuccessStatusCode)
            {
                var respuesta = JsonConvert.DeserializeObject<PersonaView>(responseContent);
                if(respuesta != null)
                {
                    
                    var persona = new Persona()
                    {
                        Apellido = respuesta.Apellido,
                        Nombre = respuesta.Nombre,
                        PersonaID = respuesta.PersonaID,
                        Usuario = new Usuario()
                        {
                            Username = respuesta.Usuario.Username,
                            Password = respuesta.Usuario.Password
                        }
                    };
                    
                    frMenu FrMenu = new frMenu(persona);
                    FrMenu.Show();
                }
                else
                {
                    txtUsuarioLogin.Clear();
                    txtContraseñaLogin.Clear();
                    MessageBox.Show("El usuario ó la contraseña ingresados no son correctos",
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                var ds = new DataService();
                var personas = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Cajero && x.Usuario.Username == usuario &&
                    x.Usuario.Password == contrasenaHash && x.Estado == true),
                    x => x.Usuario);
                var persona = personas.FirstOrDefault();

                if (persona != null)
                {
                    frMenu FrMenu = new frMenu(persona);
                    FrMenu.Show();
                }
                else
                {
                    txtUsuarioLogin.Clear();
                    txtContraseñaLogin.Clear();
                    MessageBox.Show("El usuario ó la contraseña ingresados no son correctos",
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
