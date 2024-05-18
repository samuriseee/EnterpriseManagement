namespace EnterpriseManagement2.Models
{
    public class Account
    {
        public string Id { get; set; }
        public string Workemail { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        public string EmployeeId { get; set; } 
        public Employee Employee { get; set; }
    }
}
