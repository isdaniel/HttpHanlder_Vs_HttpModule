using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandler_HttpModule
{
    public class MyHttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("==================<br/>");
            context.Response.Write("Hello World<br/>");
            context.Response.Write("==================<br/>");
        }

        public bool IsReusable { get; }
    }
}