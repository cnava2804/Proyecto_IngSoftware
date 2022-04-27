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
    public class DepositosController
    {
        public readonly FlujoDeCajaEntities db;

        public DepositosController()
        {
            db = new FlujoDeCajaEntities();
        }

        public List<DepositosViewModel> GetDepositos(string search)
        {
            List<Depositos> depositos = new List<Depositos>();
            depositos = db.Depositos.Where(d => d.Deposito_Id.ToString().Contains(search) ||
                         d.DepositoSaldoTotal.ToString().Contains(search) ||
                         d.DepositoDescripcion.ToString().Contains(search) ||
                         d.DepositoFecha.ToString().Contains(search) ||
                         d.DepositoCantidadUnlps.ToString().Contains(search) ||
                         d.DepositoCantidadDoslps.ToString().Contains(search) ||
                         d.DepositoCantidadCincolps.ToString().Contains(search) ||
                         d.DepositoCantidadDiezlps.ToString().Contains(search) ||
                         d.DepositoCantidadVeintelps.ToString().Contains(search) ||
                         d.DepositoCantidadCincuentalps.ToString().Contains(search) ||
                         d.DepositoCantidadCienlps.ToString().Contains(search) ||
                         d.DepositoCantidadDoscientoslps.ToString().Contains(search) ||
                         d.DepositoCantidadQuinientos.ToString().Contains(search) ||
                         d.DepositoCantidadCincocent.ToString().Contains(search) ||
                         d.DepositoCantidadDiezcent.ToString().Contains(search) ||
                         d.DepositoCantidadVeintecent.ToString().Contains(search) ||
                         d.DepositoCantidadCincuentacent.ToString().Contains(search)).ToList();

            return ToViewModelList(depositos);
        }

        private List<DepositosViewModel> ToViewModelList(List<Depositos> depositos)
        {
            List<DepositosViewModel> depositosViews = new List<DepositosViewModel>();

            foreach (var deposito in depositos)
            {
                depositosViews.Add(new DepositosViewModel
                {
                    Deposito_Id = deposito.Deposito_Id,
                    DepositoSaldoTotal = deposito.DepositoSaldoTotal.Value,
                    DepositoDescripcion = deposito.DepositoDescripcion,
                    DepositoFecha = deposito.DepositoFecha.Value,
                    DepositoCantidadUnlps = deposito.DepositoCantidadUnlps.Value,
                    DepositoCantidadDoslps = deposito.DepositoCantidadDoslps.Value,
                    DepositoCantidadCincolps = deposito.DepositoCantidadCincolps.Value,
                    DepositoCantidadDiezlps = deposito.DepositoCantidadDiezlps.Value,
                    DepositoCantidadVeintelps = deposito.DepositoCantidadVeintelps.Value,
                    DepositoCantidadCincuentalps = deposito.DepositoCantidadCincuentalps.Value,
                    DepositoCantidadCienlps = deposito.DepositoCantidadCienlps.Value,
                    DepositoCantidadDoscientoslps = deposito.DepositoCantidadDoscientoslps.Value,
                    DepositoCantidadQuinientos = deposito.DepositoCantidadQuinientos.Value,
                    DepositoCantidadCincocent = deposito.DepositoCantidadCincocent.Value,
                    DepositoCantidadDiezcent = deposito.DepositoCantidadDiezcent.Value,
                    DepositoCantidadVeintecent = deposito.DepositoCantidadVeintecent.Value,
                    DepositoCantidadCincuentacent = deposito.DepositoCantidadCincuentacent.Value,
                    CajaId = deposito.Caja.CajaId,
                    UsuarioId = deposito.Usuario.UsuarioId

                });
            }

            return depositosViews;
        }

        public Depositos GetDepositos(int Id)
        {
            return db.Depositos.Find(Id);
        }

        public bool Add(Depositos depositos)
        {
            try
            {
                db.Depositos.Add(depositos);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Depositos depositos)
        {
            try
            {
                db.Entry(depositos).State = EntityState.Modified;
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
                var depositos = db.Depositos.Find(Id);
                db.Depositos.Remove(depositos);
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
