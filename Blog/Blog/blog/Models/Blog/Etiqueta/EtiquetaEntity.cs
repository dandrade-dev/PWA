using Blog.Models.Blog.Postagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models.Postagem.Etiqueta
{
    public class EtiquetaEntity
    {

        public PostagemEntity Postagem { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

    }
}
