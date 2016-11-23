using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using my.domain;

namespace my.data
{
    public class EfLiteRepositorioBlog : IRepositorioBlog
    {
        
        public void Actualizar(Blog blog)
        {
            using(var context = getNewContext()) {
                var blogInDB = context.Blogs.FirstOrDefault(blo => blo.BlogId == blog.BlogId);
                
                if(blogInDB == null) {
                    return;
                }

                blogInDB.Nombre = blog.Nombre;
                blogInDB.Url = blog.Url;
                blogInDB.Articulos = blog.Articulos;

                context.SaveChanges();
            }
        }

        public void Agregar(Blog blog)
        {
            using(var context = getNewContext()) {
                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public void Eliminar(int blogId)
        {
            using(var context = getNewContext()) {
                var blogInDB = context.Blogs.FirstOrDefault(blo => blo.BlogId == blogId);
                if(blogInDB != null){
                    context.Blogs.Remove(blogInDB);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Blog> Listar()
        {
            using(var context = getNewContext()) {
                return context.Blogs.AsNoTracking()
                .Include(b=>b.Articulos).ToList();
            }
        }

        public Blog Obtener(int blogId)
        {
            using(var context = getNewContext()) {
                return context.Blogs.AsNoTracking().FirstOrDefault(blog => blog.BlogId == blogId);
            }
        }

        protected virtual BlogContext getNewContext() {
            return new BlogContext();
        }
    }
}