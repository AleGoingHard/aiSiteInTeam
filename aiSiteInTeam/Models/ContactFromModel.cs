// Models/ContactFormModel.cs
using System.ComponentModel.DataAnnotations;

public class ContactFormModel
{
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il nome non può superare i 50 caratteri")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Il cognome è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il cognome non può superare i 50 caratteri")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "L'email è obbligatoria")]
    [EmailAddress(ErrorMessage = "Inserisci un indirizzo email valido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "L'oggetto è obbligatorio")]
    [StringLength(100, ErrorMessage = "L'oggetto non può superare i 100 caratteri")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Il messaggio è obbligatorio")]
    [StringLength(1000, ErrorMessage = "Il messaggio non può superare i 1000 caratteri")]
    public string Message { get; set; }
}


