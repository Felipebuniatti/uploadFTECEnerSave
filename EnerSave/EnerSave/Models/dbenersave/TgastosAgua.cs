﻿using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TgastosAgua
    {
        public int Id { get; set; }
        public double MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
