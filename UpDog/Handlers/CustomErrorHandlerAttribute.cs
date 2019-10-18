using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Datadog.Trace;
using Newtonsoft.Json;

namespace UpDog.Handlers
{
    public class CustomErrorHandlerAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
//            var x = new List<string>() {"asd"};
//            var y = JsonConvert.SerializeObject(x);
//            Console.WriteLine(y);
            base.OnException(filterContext);
            using (var scope = Tracer.Instance.StartActive("web.request"))
            {
                var span = scope.Span;
                span.SetTag("x", "['joel']");
                span.SetException(filterContext.Exception);
            }
        }
    }
}