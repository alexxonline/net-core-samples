using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my.domain;

namespace my.web {

    [Route("api/[controller]")]
    public class BlogsController:Controller {

        private readonly IRepositorioBlog RepositorioBlog;

        public BlogsController(IRepositorioBlog repositorioBlog){
            if(repositorioBlog == null){
                throw new ArgumentNullException("repositorioBlog");
            }

            this.RepositorioBlog = repositorioBlog;
        }

        [HttpGet]
        public IEnumerable<Blog> Get() {
            return RepositorioBlog.Listar();            
        }            

        [HttpGet("{id}")]
        public Blog Get(int id){
            return RepositorioBlog.Obtener(id);
        }

        [HttpPost]
        public void Post(Blog blog){
            RepositorioBlog.Agregar(blog);
        }

        [HttpPut("{id}")]
        public void Put(Blog blog){
            RepositorioBlog.Actualizar(blog);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RepositorioBlog.Eliminar(id);
        }
    }
}