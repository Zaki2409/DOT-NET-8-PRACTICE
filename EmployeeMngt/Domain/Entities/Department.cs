using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeMngt.Domain.Entities
{
    public class Department
    {
      
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual Employee Employee { get; set; }


        //FOREIGN KEY FOR EMPLOYEE TABLE
        [ForeignKey("Employee")] //PK AND FK 
        public Guid Employee_Id { get; set; }
    }
}
