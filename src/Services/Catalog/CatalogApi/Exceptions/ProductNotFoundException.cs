namespace CatalogApi.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(Guid id) : base($"Product not found {id}")
    {

    }
}
