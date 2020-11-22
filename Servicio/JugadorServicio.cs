using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Servicio
{
    public class JugadorServicio
    {
        DAL.JugadorRepositorio repositorio;

        public JugadorServicio(SegundaEDAPW3Entities contexto)
        {
            repositorio = new DAL.JugadorRepositorio(contexto);
        }

        public List<Jugador> ListarJugadores()
        {
            return repositorio.ObtenerTodos();
        }


        public void AgregarJugador(Jugador j)
        {
            repositorio.Agregar(j);
        }

    }
}
