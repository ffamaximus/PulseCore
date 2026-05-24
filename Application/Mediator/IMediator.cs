using PulseCore.Application.Commands;
using PulseCore.Application.Queries;

namespace PulseCore.Application.Mediator;

public interface IMediator
{
    Task<Result> Send(ICommand command, CancellationToken cancellationToken = default);
    Task<Result<TResponse>> Send<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default);
    Task<IAsyncEnumerable<TResponse>> Send<TResponse>(IStreamQuery<TResponse> query, CancellationToken cancellationToken = default);
    Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default)
        where TNotification : INotification;
}
