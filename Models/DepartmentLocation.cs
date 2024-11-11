namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //composite primary key and foreign key for department
        public int DepartmentID { get; set; }

        //composite primary key and foreign key for location
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
