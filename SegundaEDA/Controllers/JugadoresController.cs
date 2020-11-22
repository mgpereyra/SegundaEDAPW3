using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Servicio;

namespace SegundaEDA.Controllers
{
    public class JugadoresController : Controller
    {
        public JugadorServicio servicio;

        public JugadoresController()
        {
            SegundaEDAPW3Entities context = new SegundaEDAPW3Entities();
            servicio = new JugadorServicio(context);
        }

        public ActionResult ListaJugadores()
        {
            List<Jugador> jugadores = servicio.ListarJugadores();
            return View(jugadores);
        }

        public ActionResult AltaJugador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaJugador(Jugador j)
        {
            try
            {
                servicio.AgregarJugador(j);
                return Redirect("/Jugadores/ListaJugadores");
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
                return View();
            }
        }
    }
}