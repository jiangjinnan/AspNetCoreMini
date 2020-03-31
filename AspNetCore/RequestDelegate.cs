using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore
{
    public delegate Task RequestDelegate(HttpContext httpContext);
}
