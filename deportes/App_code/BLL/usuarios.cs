using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DALL;

/// <summary>
/// Descripción breve de usuarios
/// </summary>
public class Usuarios
{
    public Usuarios()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static long InsertUsuario (Usuarioinfo info)
    {
        Usuario Usuario = new Usuario();

        Usuario.IDUsuario = info.IDUsuario;
        Usuario.Nombre = info.Nombre;

        Usuario.App = info.App;
        Usuario.Apm = info.Apm;

        Usuario.Contraseña = info.contraseña;
        Usuario.Correo = info.correo;

        DataClassesDataContext dc = new DataClassesDataContext();

        dc.Usuarios.InsertAllOnSubmit(Usuarios);
        dc.SubmitChanges();
        return Usuario.IDUsuario; 
        
        
         
   }
    public class Usuaariosinfo   
   {
        public long IDUsuarios { get; set; }
        public string Nombre { get; set; }

        public string App { get; set; }
        public string Apm { get; set; }

        public string Contraseña { get; set; }
        public string Correo { get; set; }
    }
}
