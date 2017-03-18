namespace CleverSharp
{
    public interface ICleverRequest<TEntity> where TEntity : ICleverRequestDocument, new()
        {
           
            GetResult<TEntity> GetById(string id);
        }


}
