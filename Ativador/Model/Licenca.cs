using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativador.Model
{
    public class Licenca
    {
        public int Id { get; set; }
        public string SerialLicenca { get; set; }
        public DateTime DataAtivacao { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
