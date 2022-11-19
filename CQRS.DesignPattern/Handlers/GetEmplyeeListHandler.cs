using CQRS.Repositorys;
using CQRS.Models;
using CQRS.DesignPattern.Queries;
using MediatR;
using CQRS.Services;

namespace CQRS.DesignPattern.Handlers;

public class GetEmplyeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
{
    private readonly IEmployeeService _service;
    public GetEmplyeeListHandler(IEmployeeService service) => _service = service;
    public Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken) => Task.FromResult(_service.GetEmployees());
}
