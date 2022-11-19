using CQRS.Models;

namespace CQRS.Repositorys;

public interface IEmployeeRepository
{
    List<Employee> GetEmployees();
    Employee AddEmployee(Employee employee);
}
