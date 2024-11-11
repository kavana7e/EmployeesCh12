﻿using System.ComponentModel.DataAnnotations;

namespace EmployeesCh12.Models
{
    public class Department
    {
        [Key] 
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; } = string.Empty;

        //navigation property
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        //navigation property
        public ICollection<DepartmentLocation> DepartmentLocations { get; set; } = new List<DepartmentLocation>();
    }
}
