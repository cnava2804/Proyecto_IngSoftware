using Multi_TornillosDAL;
using Multi_TornillosDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosBLL
{
    public class BitacoraController
    {
        private readonly FlujoDeCajaEntities db;

        public BitacoraController()
        {
            db = new FlujoDeCajaEntities();
        }

        public List<BitacoraViewModel> GetBitacoras(string Search)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = db.Bitacora.Where(u => u.Bitacora_Id.ToString().Contains(Search) ||
            u.BitacoraDescripcion.Contains(Search) ||
            u.BitacoraFecha.ToString().Contains(Search)).ToList();

            return ToViewModelList(bitacoras);
        }

        private List<BitacoraViewModel> ToViewModelList(List<Bitacora> bitacoras)
        {
            List<BitacoraViewModel> bitacoraViewModels = new List<BitacoraViewModel>();

            foreach (var bitacora in bitacoras)
            {
                bitacoraViewModels.Add(new BitacoraViewModel
                {
                    Bitacora_Id = bitacora.Bitacora_Id,
                    BitacoraDescripcion = bitacora.BitacoraDescripcion,
                    BitacoraFecha = (DateTime)bitacora.BitacoraFecha
                    
                });
            }
            return bitacoraViewModels.ToList();
        }

        public Bitacora GetBitacora(int Id)
        {
            return db.Bitacora.Find(Id);
        }

        public bool Add(Bitacora bitacora)
        {
            try
            {
                db.Bitacora.Add(bitacora);
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
