using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore
{
    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }
}
