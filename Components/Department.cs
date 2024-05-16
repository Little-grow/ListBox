using System.ComponentModel;

namespace BLAZOR_LIST_BOX.Components
{
    public class Department
    {
        public string  Id { get; set; }
        public string DisplayVal { get; set; }

        public List<Employee> employees { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
