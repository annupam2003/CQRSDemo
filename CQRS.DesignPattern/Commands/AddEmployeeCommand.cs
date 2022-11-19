using CQRS.Models;
using MediatR;

namespace CQRS.DesignPattern.Commands;

public record AddEmployeeCommand(Employee employee):IRequest<Employee> { }
