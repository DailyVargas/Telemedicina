using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Andres",apellidos= "Restrepo",direccion= "calle 23 # 42-13",telefono= "11111113", ciudad="Medellin"},
                new Usuario{id=2,nombre="Julian",apellidos= "Moncada",direccion= "calle 40 # 42-13",telefono= "99999999", ciudad="Medellin"},
                new Usuario{id=3,nombre="Pedro",apellidos= "Perez",direccion= "carrera 80 # 2-10",telefono= "2222222", ciudad="Bogota"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }

         public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
             newUsuario.id=usuarios.Max(r => r.id) +1;
            }else{
               newUsuario.id = 1;
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(e => e.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }
    }
}