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
    public class RetirosController
    {
         public readonly FlujoDeCajaEntities db;

        public RetirosController()
        {
            db = new FlujoDeCajaEntities();
        }

        public List<RetirosViewModel> GetRetiros(string search)
        {
            List<Retiros> retiros = new List<Retiros>();
            retiros = db.Retiros.Where(d => d.Retiro_Id.ToString().Contains(search) ||
                         d.RetiroSaldoTotal.ToString().Contains(search) ||
                         d.RetiroDescripcion.ToString().Contains(search) ||
                         d.RetiroFecha.ToString().Contains(search) ||
                         d.RetiroCantidadUnlps.ToString().Contains(search) ||
                         d.RetiroCantidadDoslps.ToString().Contains(search) ||
                         d.RetiroCantidadCincolps.ToString().Contains(search) ||
                         d.RetiroCantidadDiezlps.ToString().Contains(search) ||
                         d.RetiroCantidadVeintelps.ToString().Contains(search) ||
                         d.RetiroCantidadCincuentalps.ToString().Contains(search) ||
                         d.RetiroCantidadCienlps.ToString().Contains(search) ||
                         d.RetiroCantidadDoscientoslps.ToString().Contains(search) ||
                         d.RetiroCantidadQuinientos.ToString().Contains(search) ||
                         d.RetiroCantidadCincocent.ToString().Contains(search) ||
                         d.RetiroCantidadDiezcent.ToString().Contains(search) ||
                         d.RetiroCantidadVeintecent.ToString().Contains(search) ||
                         d.RetiroCantidadCincuentacent.ToString().Contains(search)).ToList();

            return ToViewModelList(retiros);
        }

        private List<RetirosViewModel> ToViewModelList(List<Retiros> retiros)
        {
            List<RetirosViewModel> retirosViews = new List<RetirosViewModel>();

            foreach (var retiro in retiros)
            {
                retirosViews.Add(new RetirosViewModel
                {
                    Retiro_Id = retiro.Retiro_Id,
                    RetiroSaldoTotal = retiro.RetiroSaldoTotal.Value,
                    RetiroDescripcion = retiro.RetiroDescripcion,
                    RetiroFecha = retiro.RetiroFecha.Value,
                    RetiroCantidadUnlps = retiro.RetiroCantidadUnlps.Value,
                    RetiroCantidadDoslps = retiro.RetiroCantidadDoslps.Value,
                    RetiroCantidadCincolps = retiro.RetiroCantidadCincolps.Value,
                    RetiroCantidadDiezlps = retiro.RetiroCantidadDiezlps.Value,
                    RetiroCantidadVeintelps = retiro.RetiroCantidadVeintelps.Value,
                    RetiroCantidadCincuentalps = retiro.RetiroCantidadCincuentalps.Value,
                    RetiroCantidadCienlps = retiro.RetiroCantidadCienlps.Value,
                    RetiroCantidadDoscientoslps = retiro.RetiroCantidadDoscientoslps.Value,
                    RetiroCantidadQuinientos = retiro.RetiroCantidadQuinientos.Value,
                    RetiroCantidadCincocent = retiro.RetiroCantidadCincocent.Value,
                    RetiroCantidadDiezcent = retiro.RetiroCantidadDiezcent.Value,
                    RetiroCantidadVeintecent = retiro.RetiroCantidadVeintecent.Value,
                    RetiroCantidadCincuentacent = retiro.RetiroCantidadCincuentacent.Value,
                    CajaId = retiro.Caja.CajaId,
                    UsuarioId = retiro.Usuario.UsuarioId

                });
            }

            return retirosViews;
        }

        public Retiros GetRetiros(int Id)
        {
            return db.Retiros.Find(Id);
        }

        public bool Add(Retiros retiros)
        {
            try
            {
                db.Retiros.Add(retiros);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Retiros retiros)
        {
            try
            {
                db.Entry(retiros).State = EntityState.Modified;
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
                var retiros = db.Retiros.Find(Id);
                db.Retiros.Remove(retiros);
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
