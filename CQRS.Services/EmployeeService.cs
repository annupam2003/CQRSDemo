using CQRS.Models;
using CQRS.Repositorys;

namespace CQRS.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    public EmployeeService(IEmployeeRepository repository) => _repository = repository;
    public Employee AddEmployee(Employee employee) => _repository.AddEmployee(employee);
    public List<Employee> GetEmployees() => _repository.GetEmployees();
}