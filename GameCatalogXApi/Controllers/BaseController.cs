using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace GameCatalogXApi.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected static void ValidateContentType(HttpRequestMessage request, string expectedContentType)
        {
            
            if (request.Content != null && request.Content.Headers != null && request.Content.Headers.ContentType != null)
            {
                var providedContentType = request.Content.Headers.ContentType;
                if (providedContentType.MediaType != expectedContentType)
                {
                    throw new UnsupportedMediaTypeException("Invalid Content Type", providedContentType);
                }
            }
            else
            {
                throw new BadRequestException("Missing Content Type");
            }

        }
    }
}
