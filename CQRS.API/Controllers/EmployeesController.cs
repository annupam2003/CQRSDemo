using CQRS.DesignPattern.Commands;
using CQRS.Models;
using CQRS.DesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IMediator mediator;

    public EmployeesController(IMediator mediator)=> this.mediator = mediator;
    
    [HttpGet]
    public async Task<List<Employee>> Get() => await mediator.Send(new GetEmployeeListQuery());

    [HttpGet("{Id}")]
    public async Task<Employee> Get(int Id) => await mediator.Send(new GetEmployeeByIdQuery(Id));
    
    [HttpPost]
    public async Task<Employee> Post(Employee employee) => await mediator.Send(new AddEmployeeCommand(employee));
}
