using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoEstacionamento.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string placa { get; set; }

        public string modelo { get; set; }
        public string cor { get; set; }

    }

}