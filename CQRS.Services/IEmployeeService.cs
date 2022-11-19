using CQRS.Models;

namespace CQRS.Services;

public interface IEmployeeService
{
    List<Employee> GetEmployees();
    Employee AddEmployee(Employee employee);
}
