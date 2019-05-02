using System;
using System.Linq;
using SistemaGymDominio.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject_GYM
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerAlEntrenadorPorCodigo()
        {
            var ctx = new GymContext();
            var entrenador = ctx.TBENTRENADORs.Find("70405060");
            Assert.IsNotNull(entrenador);
        }

        public void AgregarDosPlanesdeGimnasio()
        {
            IList<TBPLAN> nuevoPlan = new List<TBPLAN>()
            {
                new TBPLAN() { Codigo = "P02", Nombre = "Plan 4 meses+ 3 meses gratis", Costo = 200, Duracion = 3, Estado = "Activo" },
                new TBPLAN() { Codigo = "P03", Nombre = "Planverano", Costo = 250, Duracion = 3, Estado = "Activo" }
            };
            using (var context = new GymContext())
            {
                context.TBPLANs.AddRange(nuevoPlan);
                context.SaveChanges();
            }
            Assert.IsNotNull(nuevoPlan);
        }

        public void ObtenerListaDeClasesPorNombreAscendiente()
        {
            using (var ctx = new GymContext())
            {
                var clases = ctx.TBCLASEs.OrderBy(s => s.NombreClase).ToList();
            }
        }

        public void BuscarTodaslasBoletasPorEmpleado()
        {
            using (var ctx = new GymContext())
            {
                var anonymousObjResult = from s in ctx.TBBOLETAs
                                         where s.CodigoEmp == "11111111"
                                         select new
                                         {
                                             SerieBoleta = s.Serie,
                                             NumeroBoleta = s.Numero,
                                             Total = s.Total
                                         };

                foreach (var obj in anonymousObjResult)
                {
                    Console.Write(obj.SerieBoleta, obj.NumeroBoleta);
                }
            }
        }

        public void EliminarUnPlanDeGimnasioPorCodigo()
        {
            using (var context = new GymContext())
            {
                var eliminarplan = context.TBPLANs.Where(c => c.Codigo == "P03").FirstOrDefault();
                context.TBPLANs.Remove(eliminarplan);
                context.SaveChanges();
            }
        }
    }
}
