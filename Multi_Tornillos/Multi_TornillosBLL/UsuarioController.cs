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
    public class UsuarioController
    {
        private readonly FlujoDeCajaEntities db;

        public UsuarioController() 
        {
            db = new FlujoDeCajaEntities();
        }

        public List<UsuarioViewModel> GetUsuarios(string search)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = db.Usuario.Where(u => u.UsuarioId.ToString().Contains(search) || 
                                             u.UsuarioRTN.Contains(search) || u.UsuarioNombre.Contains(search) ||
                                             u.UsuarioTipo.Contains(search)).ToList();

            return ToViewModelList(usuarios);
        }

        private List<UsuarioViewModel> ToViewModelList(List<Usuario> usuarios)
        {
            List<UsuarioViewModel> usuariosViewModel = new List<UsuarioViewModel>();
            foreach (var usuario in usuarios)
            {
                usuariosViewModel.Add(new UsuarioViewModel 
                {
                    Id = usuario.UsuarioId,
                    Nombre = usuario.UsuarioNombre,
                    RTN = usuario.UsuarioRTN,
                    Password = usuario.UsuarioPassword,
                    Tipo = usuario.UsuarioTipo
                });
            }
            return usuariosViewModel;
        }

        public Usuario GetUsuario(int id)
        {
            return db.Usuario.Find(id);
        }

        
        public bool Add(Usuario usuario)
        {
            try
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Usuario usuario)
        {
            try
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var usuario = db.Usuario.Find(id);
                db.Usuario.Remove(usuario);
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
