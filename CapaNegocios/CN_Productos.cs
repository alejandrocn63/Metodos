using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocios
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod (string nombre, string descrip, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, descrip, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarProd(string nombre, string descrip, string marca, string precio, string stock, string Id)
        {
            objetoCD.Editar(nombre, descrip, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(Id));
        }
        public void EliminarProd(string Id)
        {
            objetoCD.Eliminar(Convert.ToInt32(Id));
        }
    }
}
