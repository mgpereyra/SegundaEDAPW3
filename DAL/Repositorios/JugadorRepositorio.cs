using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JugadorRepositorio
    {
        SegundaEDAPW3Entities ctx;

        public JugadorRepositorio(SegundaEDAPW3Entities contexto)
        {
            ctx = contexto;
        }

        public List<Jugador> ObtenerTodos()
        {
            return ctx.Jugador.ToList();
        }

        public void Agregar(Jugador j)
        {
            ctx.Jugador.Add(j);
            ctx.SaveChanges();            
        }
    }
}
