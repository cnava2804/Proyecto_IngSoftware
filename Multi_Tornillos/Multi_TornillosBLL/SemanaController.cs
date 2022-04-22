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
   public class SemanaController
    {
        public readonly FlujoDeCajaEntities db;

        public SemanaController()
        {         

           db = new FlujoDeCajaEntities();

        }

        public List<SemanaViewModel> GetSemanas(string search)
        {
            List<Semana> semanas = new List<Semana>();
            semanas = db.Semana.Where(c => c.SemanaId.ToString().Contains(search) ||
                                       c.SemanaNombre.Contains(search)).ToList();


            return ToViewModelList(semanas);
        }

        private List<SemanaViewModel> ToViewModelList(List<Semana> semanas)
        {
            List<SemanaViewModel> semanaViewModel = new List<SemanaViewModel>();

            foreach (var semana in semanas)
            {
                semanaViewModel.Add(new SemanaViewModel
                {
                    SemanaId = semana.SemanaId,
                    SemanaNombre = semana.SemanaNombre
                });
            }

            return semanaViewModel.ToList();
        }

        public Semana GetSemana(int Id)
        {
            return db.Semana.Find(Id);
        }

        public bool Add(Semana semana)
        {
            try
            {
                db.Semana.Add(semana);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Semana semana)
        {
            try
            {
                db.Entry(semana).State = EntityState.Modified;
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
                var semana = db.Semana.Find(Id);
                db.Semana.Remove(semana);
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
