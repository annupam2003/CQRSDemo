using CQRS.Models;
using CQRS.DesignPattern.Queries;
using MediatR;

namespace CQRS.DesignPattern.Handlers;

public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
{
    private readonly IMediator mediator;

    public GetEmployeeByIdHandler(IMediator mediator)
    {
        this.mediator = mediator;
    }
    public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        var employees = await mediator.Send(new GetEmployeeListQuery());
        return employees.FirstOrDefault(x=>x.Id == request.Id);
    }
}
