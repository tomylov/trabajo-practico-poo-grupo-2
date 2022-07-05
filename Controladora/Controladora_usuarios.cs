using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_usuarios
    {
        private static Controladora_usuarios _instancia;

        private Controladora_usuarios() { }

        public static Controladora_usuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Controladora_usuarios();
            }
            return _instancia;
        }

        public List<Modelo.Usuario> Listar_Usuarios()
        {
            return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.ToList();
        }

        public void Agregar_Usuario(Modelo.Usuario usuario)
        {
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Add(usuario);
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Usuario(Modelo.Usuario usuario)
        {
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Remove(usuario);
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Modelo.Usuario Obtener_Usuario(int CODIGO)
        {
            return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Find(CODIGO);
        }
    }
}
