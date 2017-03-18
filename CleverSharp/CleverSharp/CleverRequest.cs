using CleverSharp.Helper;
using CleverSharp.Models;
using Newtonsoft.Json;
using System;

namespace CleverSharp
{
    public class CleverRequest<TEntity> : ICleverRequest<TEntity> where TEntity : ICleverRequestDocument , new()
    {
        readonly WebHelper _webHelper;
        readonly string  _cleverAccessToken;
        readonly string _url;
        readonly string _entityName;
        public CleverRequest(string cleverAccessTokem)
        {
            _webHelper = new WebHelper();
            _cleverAccessToken = cleverAccessTokem;
            _url = "https://api.clever.com/v1.1";
            _entityName = (typeof(TEntity).Name.ToLower());

        }

       

        public virtual GetResult<TEntity> GetById(string id)
        {
            try
            {
                
                return GetWithException(id);
            }
            catch (Exception ex)
            {
                return new GetResult<TEntity> { error = "An error occured " + ex.Message, IsError = true };
            }
        }

        public virtual GetResult<TEntity> GetWithException(string id)
        {

            string url = $"{_url}/{_entityName}/{id}";
            var jsonResult = _webHelper.GetRequest(url,_cleverAccessToken);

            if (jsonResult.IsError)
            {
                return new GetResult<TEntity> { error = jsonResult.exeption, IsError = true };
            }

            GetResult<TEntity> GetResult = JsonConvert.DeserializeObject<GetResult<TEntity>>(jsonResult.json);
            
            return GetResult;
        }
    }


}
