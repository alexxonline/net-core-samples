using System.Collections.Generic;

namespace my.domain {
    public interface IRepositorioBlog {
        Blog Obtener(int blogId);
        IEnumerable<Blog> Listar();
        void Agregar(Blog blog);
        void Actualizar(Blog blog);
        void Eliminar(int blogId);

    }
}