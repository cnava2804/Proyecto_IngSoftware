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
    public class CajaController
    {
        public readonly FlujoDeCajaEntities db;

        public CajaController()
        {
            db = new FlujoDeCajaEntities();
            
        }

        public List<CajaViewModel> GetCajas(string search)
        {
            List<Caja> cajas = new List<Caja>();
            cajas = db.Caja.Where(c => c.CajaId.ToString().Contains(search) ||
                                       c.CajaNumero.Contains(search) || 
                                       c.CajaSaldoTotal.ToString().Contains(search)).ToList();
            
                        
            return ToViewModelList(cajas);
        }

        private List<CajaViewModel> ToViewModelList(List<Caja> cajas)
        {
            List<CajaViewModel> cajasViewModel = new List<CajaViewModel>();

            foreach (var caja in cajas)
            {
                cajasViewModel.Add(new CajaViewModel 
                {
                    CajaId = caja.CajaId,
                    CajaNumero= caja.CajaNumero,
                    CajaSaldoTotal = caja.CajaSaldoTotal.Value
                });
            }

            return cajasViewModel.ToList();
        }

        public Caja GetCaja(int Id)
        {
            return db.Caja.Find(Id);
        }

       

        public bool Add(Caja caja)
        {
            try
            {
                db.Caja.Add(caja);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }

        public bool Edit(Caja caja)
        {
            try
            {
                db.Entry(caja).State = EntityState.Modified;
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
                var caja = db.Caja.Find(Id);
                db.Caja.Remove(caja);
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
