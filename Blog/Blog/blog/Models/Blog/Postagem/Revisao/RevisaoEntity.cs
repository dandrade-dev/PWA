using Blog.Models.Blog.Postagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models.Postagem.Revisao
{
    public class RevisaoEntity
    {
        public PostagemEntity Postagem { get; set; }
        public string Texto { get; set; }
        public int Versao { get; set; }
        public DateTime Data { get; set; }
    }
}
