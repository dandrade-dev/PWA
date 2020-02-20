using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models.Postagem.Revisao.Comentario
{
    public class ComentarioEntity
    {

        public RevisaoEntity Revisao { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
    }
}
