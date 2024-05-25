using System.ComponentModel.DataAnnotations;

namespace EmployeeMngt.Domain.Entities
{
    public class Employee
    {
        [Key]
        public Guid Employee_id { get; set; }
        public string Employee_name { get; set; }
        public string Employee_gender { get; set; }
        public string Employee_phone { get; set; }
        public string Employee_email { get; set; }

        // RELATION SHIP WITH ADDRESS MDOEL CLASS
        public virtual Address Employee_address { get; set; }
        // RELATION SHIP WITH DEPARTMENT MODEL CLASS
        public virtual Department Employee_Department { get; set; }
        



    }
}
