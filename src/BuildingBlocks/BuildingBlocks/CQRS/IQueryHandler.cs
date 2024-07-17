using MediatR;

namespace BuildingBlocks.CQRS;

internal interface IQueryHandler<in IQuery, TResponse> : IRequestHandler<IQuery, TResponse>
        where IQuery : IQuery<TResponse>
        where TResponse : notnull
{
}
