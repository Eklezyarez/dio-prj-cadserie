using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_prj_cadserie.Series
{
    public class Series : EntidadeBase
    {
        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}
    }
}
