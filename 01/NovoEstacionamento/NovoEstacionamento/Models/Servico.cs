﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoEstacionamento.Models
{
     class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public string Descricao { get; set; }
    }
}
