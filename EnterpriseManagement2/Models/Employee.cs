namespace EnterpriseManagement2.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Workemail { get; set; }
        public string Birthday { get; set; }
        public string? DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
