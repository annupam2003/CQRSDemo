using CQRS.DesignPattern.Commands;
using CQRS.Models;
using CQRS.Repositorys;
using CQRS.Services;
using MediatR;

namespace CQRS.DesignPattern.Handlers;

public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
{
    private readonly IEmployeeService _service;
    public AddEmployeeHandler(IEmployeeService service) => _service = service;
    public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken) => Task.FromResult(_service.AddEmployee(request.employee));
}
