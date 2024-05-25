using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeMngt.Domain.Entities
{
    public class Address
    {

        
        [Key]
        public int Adress_Id { get; set; }
        public string Employee_city { get; set; }
        public string Employee_zipcode { get; set; }
        public string Employee_state { get; set; }
        public string Employee_country { get; set; }

        public virtual Employee Employee { get; set; }



        //FOREIGN KEY FOR EMPLOYEE TABLE
        [ForeignKey("Employee")] //PK AND FK 
        public Guid Employee_Id { get; set; }
    }
}
