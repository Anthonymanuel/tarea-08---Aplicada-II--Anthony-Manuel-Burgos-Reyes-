using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.NombreUsuario = "";
            this.Contrasena = "";
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Insert Into Usuarios(NombreUsuario,Contrasena) Values('{0}','{1}')",this.NombreUsuario,this.Contrasena));
            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Update Usuarios set NombreUsuario = '{0}',Contrasena = '{1}' Where UsuarioId = '{2}' ",this.NombreUsuario,this.Contrasena,this.UsuarioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Delete Usuarios Where UsuarioId = {0}",this.UsuarioId));
            return retorno;
        }


        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();


            dt = conexion.ObtenerDatos(String.Format("Select * From Usuarios Where UsuarioId = {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = " ";

            if (!Orden.Equals(""))
                ordenFinal = " Orden by " + Orden;
            return conexion.ObtenerDatos("Select " + Campos + " From Usuarios Where " +
                                          Condicion + " " + ordenFinal);
        }
        public  bool Inicio(string usuario, string contrasena)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();


            dt = conexion.ObtenerDatos(String.Format("Select * From Usuarios Where NombreUsuario = '{0}' and Contrasena ='{1}'",usuario,contrasena));
            if (dt.Rows.Count > 0)
            {
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
            }
            return dt.Rows.Count > 0;
        }
    }
}
