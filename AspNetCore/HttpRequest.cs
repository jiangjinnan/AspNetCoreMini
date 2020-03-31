using System;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCore
{
public class HttpRequest
{
    private readonly IHttpRequestFeature _feature;

    public Uri Url => _feature.Url;
    public NameValueCollection Headers => _feature.Headers;
    public Stream Body => _feature.Body;

    public HttpRequest(IFeatureCollection features) => _feature = features.Get<IHttpRequestFeature>();
}
}