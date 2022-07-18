using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_ventas
    {
        private static Controladora_ventas _instancia;

        private Controladora_ventas() { }

        public static Controladora_ventas obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Controladora_ventas();
            }
            return _instancia;
        }

        public List<Modelo.Ventas> Listar_Ventas()
        {
            return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Ventas.ToList();
        }

        public void Agregar_Ventas(Modelo.Ventas ventas)
        {
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Add(ventas);
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Ventas(Modelo.Ventas ventas)
        {
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Remove(ventas);
            Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Modelo.Ventas Obtener_Ventas(int CODIGO)
        {
            return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Find(CODIGO);
        }
    }
}
