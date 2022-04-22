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
   public class DiaController
    {
        public readonly FlujoDeCajaEntities db;

        public DiaController()
        {
            db = new FlujoDeCajaEntities();

        }

        public List<DiaViewModel> GetDias(string search)
        {
            List<Dia> dias = new List<Dia>();
            dias = db.Dia.Where(c => c.DiaId.ToString().Contains(search) ||
                                       c.DiaNombre.Contains(search)).ToList();


            return ToViewModelList(dias);
        }

        private List<DiaViewModel> ToViewModelList(List<Dia> dias )
        {
            List<DiaViewModel> diasViewModel = new List<DiaViewModel>();

            foreach (var dia in dias)
            {
                diasViewModel.Add(new DiaViewModel
                {
                    DiaId = dia.DiaId,
                    DiaNombre = dia.DiaNombre
                });
            }

            return diasViewModel.ToList();
        }

        public Dia GetDia(int Id)
        {
            return db.Dia.Find(Id);
        }

        public bool Add(Dia dia)
        {
            try
            {
                db.Dia.Add(dia);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Dia dia)
        {
            try
            {
                db.Entry(dia).State = EntityState.Modified;
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
                var dia = db.Dia.Find(Id);
                db.Dia.Remove(dia);
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

