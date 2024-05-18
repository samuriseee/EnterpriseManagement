using EnterpriseManagement2.Context;
using EnterpriseManagement2.Models;

namespace EnterpriseManagement2.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployeeById(string id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            //use LinQ to get all employees
            Console.WriteLine(_context);
            return _context.Employees.ToList();
        }
    }
}
