﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoEstacionamento.Models
{
    public class Vaga
    {
        public int Id { get; set; }
       public string Localizacao { get; set; }

        public string Tipo { get; set; } // Ex: "Grande", "Motos"
    }
}
