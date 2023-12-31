﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntidadesDTO.Monedas
{
    public class MonedaVerDto
    {
        public Guid id { get; set; }
        public string? nombre{ get; set; }
        public string? codigo { get; set; }
        public float? factor { get; set; }

        public string resumenMoneda { get; set; }
    }
}