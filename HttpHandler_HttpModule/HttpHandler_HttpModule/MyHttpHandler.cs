using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace HttpHandler_HttpModule
{
    public class MyHttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var filePath = context.Server.MapPath(context.Request.Path);
            
            context.Response.ContentType = "text/html";
            context.Response.Write("==================<br/>");
            context.Response.Write(File.ReadAllText(filePath));
            context.Response.Write("==================<br/>");
        }

        public bool IsReusable { get; }
    }
}