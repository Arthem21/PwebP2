
using System.ComponentModel.DataAnnotations;

//Esta clase se usa como modelo para crear una tabla en la base de datos (Cristobal Garcia Lopez 2023-1634)

public class Personas{

    public int id{set;get;}=0;

    //Requisitos del atributo (Cristobal Garcia Lopez 2023-1634)
    [Required(ErrorMessage ="El campo nombre es requerido")]
    public string Nombre{set;get;}="";

    //Requisitos del atributo (Cristobal Garcia Lopez 2023-1634)
    [Required(ErrorMessage ="El campo apellido es requerido")]
    public string Apellido{set;get;}="";

    //Requisitos del atributo (Cristobal Garcia Lopez 2023-1634)
    [Required(ErrorMessage ="El campo telefono es requerido")]
    [MinLength(10,ErrorMessage ="El campo telefono debe tener al menos 10 digitos")]
    [MaxLength(15,ErrorMessage ="El campo telefono debe tener menos de 15 digitos")]
    public string Telefono{set;get;}="";

    //Requisitos del atributo (Cristobal Garcia Lopez 2023-1634)
    [MinLength(4,ErrorMessage ="El campo telefono debe tener al menos 4 digitos")]
    [Required(ErrorMessage ="El campo correo es requerido")]
    public string Correo{set;get;}="";
}