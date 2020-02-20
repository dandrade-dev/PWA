using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models.Postagem.Revisao.Classificacao
{
    public class ClassificacaoEntity
    {
        public RevisaoEntity Revisao { get; set; }
        public bool Classificacao { get; set; }
    }
}
