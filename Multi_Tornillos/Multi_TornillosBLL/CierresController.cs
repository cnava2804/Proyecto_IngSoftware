using Multi_TornillosDAL;
using Multi_TornillosDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosBLL
{
    public class CierresController
    {
        public readonly FlujoDeCajaEntities db;

       public CierresController()
        {
            db = new FlujoDeCajaEntities();
        }

        public List<CierresViewModel> GetCierres(string search)
        {
            List<Cierres> cierres = new List<Cierres>();
            cierres = db.Cierres.Where(c => c.Cierre_Id.ToString().Contains(search) ||
                         c.CierreTotal.ToString().Contains(search) ||
                         c.CierreFecha.ToString().Contains(search)||
                         c.TipoCierre.Contains(search)).ToList();

            return ToViewModelList(cierres);

        }


        private List<CierresViewModel> ToViewModelList(List<Cierres> cierres)
        {
            List<CierresViewModel> cierresViews = new List<CierresViewModel>();

            foreach (var cierre in cierres)
            {
                cierresViews.Add(new CierresViewModel
                {
                    Cierre_Id = cierre.Cierre_Id,
                    CierreTotal = cierre.CierreTotal.Value,
                    TipoCierre= cierre.TipoCierre.ToString(),
                    CierreFechaInicial= cierre.CierreFechaInicial.Value,
                    CierreFecha = cierre.CierreFecha.Value,
                    CierreFechaFinal= cierre.CierreFechaFinal.Value,
                    CajaId = cierre.Caja.CajaId,
                    UsuarioId = cierre.Usuario.UsuarioId
                    

                });
            }

            return cierresViews;
        }

        public Cierres GetCierre(int Id)
        {
            return db.Cierres.Find(Id);
        }

        public bool Add(Cierres cierres)
        {
            try
            {
                db.Cierres.Add(cierres);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Cierres cierres)
        {
            try
            {
                db.Entry(cierres).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
