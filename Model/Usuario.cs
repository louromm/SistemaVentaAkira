
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SistemaVentaAkira.Model
{

using System;
    using System.Collections.Generic;
    
public partial class Usuario
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Usuario()
    {

        this.CabeceraFactura = new HashSet<CabeceraFactura>();

    }


    public int Id_usuario { get; set; }

    public int Id_Rol { get; set; }

    public string Us_nombre { get; set; }

    public string Us_apellido { get; set; }

    public string Us_email { get; set; }

    public string Us_telefono { get; set; }

    public string Us_clave { get; set; }

    public System.DateTime Us_fechaNacimiento { get; set; }

    public bool Us_estado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CabeceraFactura> CabeceraFactura { get; set; }

    public virtual Rol Rol { get; set; }

}

}
