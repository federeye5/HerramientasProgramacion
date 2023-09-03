using System.ComponentModel.DataAnnotations;

public class Form{
    [Required]
    [Display (Name = "Correo")]
    public string Mail {get; set;}
    [Required]
    [Display (Name ="Contraseña")]
    public string Password {get; set;}
}