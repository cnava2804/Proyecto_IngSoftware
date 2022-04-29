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
    public class CierreDiaController
    {
        public readonly FlujoDeCajaEntities db;

        public CierreDiaController()
        {
            db = new FlujoDeCajaEntities();
        }

        public List<CierreDiaViewModel> GetCierreDias(string search)
        {
            List<CierreDias> cierreDias = new List<CierreDias>();
                 cierreDias = db.CierreDias.Where(c => c.CierreDia_Id.ToString().Contains(search) ||
                              c.CierreDiaTotal.ToString().Contains(search) ||
                              c.CierreDiaFecha.ToString().Contains(search)).ToList();

            return ToViewModelList(cierreDias);
        }

        
        private List<CierreDiaViewModel> ToViewModelList(List<CierreDias> cierreDias)
        {
            List<CierreDiaViewModel> cierreDiaViews = new List<CierreDiaViewModel>();

            foreach (var cierreDia in cierreDias)
            {
                cierreDiaViews.Add(new CierreDiaViewModel
                {
                    CierreDia_Id = cierreDia.CierreDia_Id,
                    CierreDiaTotal = cierreDia.CierreDiaTotal.Value,
                    CierreDiaFecha = cierreDia.CierreDiaFecha.Value,
                    SaldoInicial_Id = cierreDia.SaldosIniciales.SaldoInicial_Id,
                    CajaId = cierreDia.Caja.CajaId,
                    UsuarioId = cierreDia.Usuario.UsuarioId
                    
                });
            }

            return cierreDiaViews;
        }

        public CierreDias GetCierreDias(int Id)
        {
            return db.CierreDias.Find(Id);
        }

        public bool Add(CierreDias cierreDias)
        {
            try
            {
                db.CierreDias.Add(cierreDias);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(CierreDias cierreDias)
        {
            try
            {
                db.Entry(cierreDias).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var cierreDias = db.CierreDias.Find(Id);
                db.CierreDias.Remove(cierreDias);
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
