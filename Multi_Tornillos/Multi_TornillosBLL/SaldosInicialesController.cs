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
    public class SaldosInicialesController
    {
        public readonly FlujoDeCajaEntities db;

        public SaldosInicialesController() 
        {
            db = new FlujoDeCajaEntities();
        }

        public List<SaldosInicialesViewModel> GetSaldosIniciales(string search) 
        {
            List<SaldosIniciales> saldosIniciales = new List<SaldosIniciales>();
            saldosIniciales = db.SaldosIniciales.Where(s => s.SaldoInicial_Id.ToString().Contains(search) ||
                              s.SaldoInicialTotal.ToString().Contains(search) ||
                              s.SaldoInicialFecha.ToString().Contains(search) ||
                              s.CajaId.ToString().Contains(search) ||
                              s.UsuarioId.ToString().Contains(search)).ToList();

            return ToViewModelList(saldosIniciales);
        }

        private List<SaldosInicialesViewModel> ToViewModelList(List<SaldosIniciales> saldosIniciales)
        {
            List<SaldosInicialesViewModel> saldosInicialesViews = new List<SaldosInicialesViewModel>();

            foreach (var saldo in saldosIniciales)
            {
                saldosInicialesViews.Add(new SaldosInicialesViewModel
                {
                    SaldoInicial_Id = saldo.SaldoInicial_Id,
                    SaldoInicialTotal = (decimal)saldo.SaldoInicialTotal,
                    SaldoInicialFecha = (DateTime)saldo.SaldoInicialFecha
                    
                });
            }

            return saldosInicialesViews;
        }

        public SaldosIniciales GetSaldoInicial(int Id)
        {
            return db.SaldosIniciales.Find(Id);
        }

        public bool Add(SaldosIniciales saldosIniciales)
        {
            try
            {
                db.SaldosIniciales.Add(saldosIniciales);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(SaldosIniciales saldosIniciales)
        {
            try
            {
                db.Entry(saldosIniciales).State = EntityState.Modified;
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
                var saldosIniciales = db.SaldosIniciales.Find(Id);
                db.SaldosIniciales.Remove(saldosIniciales);
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
