using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_Detalle
    {
            private static Controladora_Detalle _instancia;

            private Controladora_Detalle() { }

            public static Controladora_Detalle obtener_instancia()
            {
                if (_instancia == null)
                {
                    _instancia = new Controladora_Detalle();
                }
                return _instancia;
            }

            public List<Modelo.Detalle_ventas> Listar_Detalle()
            {
                return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.ToList();
            }

            public void Agregar_Detalle(Modelo.Detalle_ventas detalle)
            {
                Modelo.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Add(detalle);
                Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
            }
            public void Eliminar_Ventas(Modelo.Detalle_ventas detalle)
            {
                Modelo.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Remove(detalle);
                Modelo.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
            }
            public Modelo.Detalle_ventas Obtener_Detalle(int CODIGO)
            {
                return Modelo.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Find(CODIGO);
            }
        }
}
