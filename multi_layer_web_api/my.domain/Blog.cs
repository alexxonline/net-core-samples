using System.Collections.Generic;

namespace my.domain
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Nombre { get; set; }

        public List<Articulo> Articulos { get; set; }
    }
}