using CQRS.Models;

namespace CQRS.Repositorys;

public class EmployeeRepository : IEmployeeRepository
{
    private static List<Employee> employees = new List<Employee>
    {
        new Employee{ Id=1, Name="kumar" , Cost=15000 },
        new Employee{ Id=2, Name="singh" , Cost=25000 },
        new Employee{ Id=3, Name="baba" , Cost=5000 },
        new Employee{ Id=4, Name="raja" , Cost=10000 }
    };
    public Employee AddEmployee(Employee employee)
    {
        employees.Add(employee);
        return employee;
    }
    public List<Employee> GetEmployees() => employees;
}