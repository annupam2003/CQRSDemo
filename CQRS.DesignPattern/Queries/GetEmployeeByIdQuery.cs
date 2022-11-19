using CQRS.Models;
using MediatR;

namespace CQRS.DesignPattern.Queries;

public record GetEmployeeByIdQuery(int Id):IRequest<Employee> { }
