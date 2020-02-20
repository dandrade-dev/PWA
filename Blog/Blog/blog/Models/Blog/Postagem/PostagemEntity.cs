using blog.Models.Postagem.Etiqueta;
using blog.Models.Postagem.Revisao;
using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using System.Collections.Generic;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public string Titulo { get; set; }
        public AutorEntity Autor { get; set; }
        public CategoriaEntity Categoria { get; set; }

        public List<EtiquetaEntity> Etiquetas { get; set; }
        public List<RevisaoEntity> Revisoes { get; set; }


    }
}
