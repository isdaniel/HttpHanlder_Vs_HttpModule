using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandler_HttpModule
{
    public class MyHttpModule:IHttpModule
    {
        public void Init(HttpApplication context)
        {
          
            context.BeginRequest += (sender, args) => ShowStep(sender, "BeginRequest");

            context.AuthorizeRequest += (sender, args) => ShowStep(sender, "AuthorizeRequest");

            context.PostResolveRequestCache += (sender, args) => ShowStep(sender, "PostResolveRequestCache");

            context.MapRequestHandler += (sender, args) => ShowStep(sender, "MapRequestHandler");

            context.AcquireRequestState += (sender, args) => ShowStep(sender, "AcquireRequestState");

            context.PreRequestHandlerExecute += (sender, args) => ShowStep(sender, "PreRequestHandlerExecute");

            //這中間執行IHttpHandler.

            context.PostRequestHandlerExecute += (sender, args) => ShowStep(sender, "PostRequestHandlerExecute");

            context.EndRequest += (sender, args) => ShowStep(sender, "EndRequest");

            context.PreSendRequestHeaders += (sender, args) => ShowStep(sender, "PreSendRequestHeaders");
        }

        private void ShowStep(object app,string eventName)
        {
            var http = (HttpApplication)app;
            http.Response.Write($"Step {eventName}<br/>");
        }

        public void Dispose()
        {
        }
    }
}