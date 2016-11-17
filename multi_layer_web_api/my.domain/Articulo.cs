namespace my.domain
{
    public class Articulo
    {
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}