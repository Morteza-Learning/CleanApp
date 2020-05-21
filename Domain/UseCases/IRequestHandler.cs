namespace Domain.UseCases
{
    internal interface IRequestHandler<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest data);
    }

    internal interface IRequestHandler<out TResponse>
    {
        TResponse Handle();
    }
}