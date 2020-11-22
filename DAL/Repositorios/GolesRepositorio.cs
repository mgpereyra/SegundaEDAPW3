using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GolesRepositorio
    {
        SegundaEDAPW3Entities ctx;

        public GolesRepositorio(SegundaEDAPW3Entities contexto)
        {
            ctx = contexto;
        }

        public List<GolesPorJugadorEquipo> ObtenerTodos()
        {
            return ctx.GolesPorJugadorEquipo.ToList();
        }

        public void Agregar(GolesPorJugadorEquipo g)
        {
            ctx.GolesPorJugadorEquipo.Add(g);
            ctx.SaveChanges();
        }

        public void Modificar(GolesPorJugadorEquipo g)
        {
            Boolean yaExiste = false;
            Jugador j2 = ctx.Jugador.Find(g.idJugador);
            GolesPorJugadorEquipo golesActual = null;
            List<GolesPorJugadorEquipo> registros= ctx.GolesPorJugadorEquipo.ToList();
            foreach (GolesPorJugadorEquipo registro in registros)
            {
                // Como el usuario no busca por nombre de Jugador, no valido ya que siempre es correcto
                // y j1,j2 nunca serán "null"
                Jugador j1 = ctx.Jugador.Find(registro.idJugador);
                if (registro.equipo.Equals(g.equipo)&&j1.nombre.Equals(j2.nombre))
                {
                    golesActual = registro;
                    yaExiste = true;
                }
            }
            if (yaExiste)
            { 
                golesActual.idJugador = g.idJugador;
                golesActual.equipo = g.equipo;
                golesActual.cantidadGoles = g.cantidadGoles;
                ctx.SaveChanges();
            }
            else
            {
                Agregar(g);
            }
        }
    }
}
