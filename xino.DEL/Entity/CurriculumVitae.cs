
namespace xino.DEL.Entity;

   public class CurriculumVitae
    {
    public int Id { get; set; }

    public DateTime BuildDate { get; set; } 

    public string FullName { get; set; }

    public string FatherName { get; set; }

    public string IDNumber { get; set; }

    public JobPosition JobPosition { get; set; }

    public string City { get; set; }

    public gender gender { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string File { get; set; }

    public string Text { get; set; }

    public bool IsChacket { get; set; }


}


public enum JobPosition
{
    ArchitectureDepartment,   // واحد معماری
    SalesDepartment,          // واحد فروش
    AdministrationDepartment  // واحد اداری
}


public enum gender
{
    
    Male,
    Female
}


