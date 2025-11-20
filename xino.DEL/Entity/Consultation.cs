

namespace xino.DEL.Entity;

public class Consultation
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Role { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string Exhibition { get; set; }

    public string AddressExhibition { get; set; }

    public string Company { get; set; }

    public DateTime DateExhibition { get; set; }

    public int Meterage { get; set; }  

    public DateTime BuildDate { get; set; } 

    public string TextExhibition { get; set; }

    public bool IsChacket { get; set; }
}

