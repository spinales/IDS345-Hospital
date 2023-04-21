﻿using System;
using Modelos;

namespace API.Services
{
    public class AuditoriaAccion
    {
        public async void RegistrarAccion(string descripcion, int userID)
        {
            var ds = new DataService();
            await ds.Add<HistoricoAcciones>(new HistoricoAcciones()
            {
                CreatedAt = DateTime.Now,
                Descripcion = descripcion,
                UsuarioID = userID
            });
        }
    }
}