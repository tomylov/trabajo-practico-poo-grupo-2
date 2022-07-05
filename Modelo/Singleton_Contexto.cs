using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Singleton_Contexto
    {
        private static Singleton_Contexto _instancia;
        private static ContextoContainer _contexto;

        private Singleton_Contexto() { }

        public static Singleton_Contexto obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Singleton_Contexto();
                _contexto = new ContextoContainer();
            }
            return _instancia;
        }

        public ContextoContainer Contexto
        {
            get { return _contexto; }
        }
    }
}
