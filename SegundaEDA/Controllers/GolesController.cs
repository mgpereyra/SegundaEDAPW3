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
    public class GolesController : Controller
    {
        GolesServicio servicio;
        JugadorServicio servicioJugador;
        List<Jugador> jugadores;

        public GolesController()
        {
            SegundaEDAPW3Entities context = new SegundaEDAPW3Entities();
            servicio = new GolesServicio(context);
            servicioJugador = new JugadorServicio(context);
        }

        public ActionResult ListaGolesJugador()
        {
            List<GolesPorJugadorEquipo> goles = servicio.ListarGoles();
            return View(goles);
        }

        public ActionResult AltaGolesJugador()
        {
            jugadores = servicioJugador.ListarJugadores();
            ViewBag.Jugadores = jugadores;
            return View(new GolesPorJugadorEquipo());
        }

        [HttpPost]
        public ActionResult AltaGolesJugador(GolesPorJugadorEquipo g)
        {
            try
            {
                servicio.AgregarGoles(g);
                return Redirect("/Goles/ListaGolesJugador");
            }
            catch (DbEntityValidationException e)
            {
                jugadores = servicioJugador.ListarJugadores();
                ViewBag.Jugadores = jugadores;
                Console.WriteLine(e);
                return View(new GolesPorJugadorEquipo());
            }
        }
    }
}