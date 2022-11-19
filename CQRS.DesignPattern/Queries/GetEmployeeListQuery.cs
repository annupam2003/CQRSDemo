using CQRS.Models;
using MediatR;

namespace CQRS.DesignPattern.Queries;
public record GetEmployeeListQuery():IRequest<List<Employee>> { }
