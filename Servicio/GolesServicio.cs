using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Servicio
{
    public class GolesServicio
    {
        DAL.GolesRepositorio repositorio;

        public GolesServicio(SegundaEDAPW3Entities contexto)
        {
            repositorio = new DAL.GolesRepositorio(contexto);
        }

        public List<GolesPorJugadorEquipo> ListarGoles()
        {
            return repositorio.ObtenerTodos();
        }


        public void AgregarGoles(GolesPorJugadorEquipo g)
        {
            repositorio.Modificar(g);
        }

    }
}
