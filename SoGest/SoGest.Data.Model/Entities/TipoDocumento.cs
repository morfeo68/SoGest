﻿using SoGest.Data.Model.Interfaces;

namespace SoGest.Data.Model.Entities
{
    public class TipoDocumento : IBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
