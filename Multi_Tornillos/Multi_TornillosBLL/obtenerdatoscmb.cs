using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_TornillosBLL
{
    public class obtenerdatoscmb
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-MP6SVTR;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True");
        public void rellenar(ComboBox cb)
        {
            SqlCommand sql = new SqlCommand("SELECT * FROM Caja", conn);
            conn.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            };
            conn.Close();
            cb.Items.Insert(0, "--seleccione--");
            cb.SelectedIndex = 0;
        }
        public string[] obtenerdatos(string Numero)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Caja WHERE CajaNumero='" + Numero + "'", conn);
            SqlDataReader dr = sql.ExecuteReader();
            string[] cajas = null;
            while (dr.Read())
            {
                string[] caja =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString()
                };
                cajas = caja;
            }
            conn.Close();
            return cajas;
        }
        public void MaxId(int id)
        {
            
            
        }
    }
}
