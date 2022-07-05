using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_perfil
    {
        private static Controladora_perfil _instancia;

        private Controladora_perfil() { }

        public static Controladora_perfil obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Controladora_perfil();
            }
            return _instancia;
        }

        public List<Modelo.Perfil> Listar_Perfiles()
        {
            return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Perfiles.ToList();
        }

        public void Llenar_Lista_Perfiles(List<Modelo.Perfil> perfiles)
        {
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.Perfiles.AddRange(perfiles);
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
