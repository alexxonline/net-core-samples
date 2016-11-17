namespace my.web.Models {
    public class Sistema {

        public Sistema(string nombre, int version) {
            this.Nombre = nombre;
            this.Version = version;
        }

        public string Nombre {get;set;}
        public int Version {get;set;}
    }
}