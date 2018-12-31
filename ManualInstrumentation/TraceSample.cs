using Datadog.Trace;

namespace ManualInstrumentation
{
    public class TraceSample
    {
        public string Method1()
        {
            using (var scope = Tracer.Instance.StartActive("method1"))
            {
                var span = scope.Span;
                span.Type = SpanTypes.Web;
                span.ResourceName = "http://localhost/api/method1";
                span.SetTag(Tags.HttpMethod, "GET");

                return "Hello from method 1";
            }
        }

        public string Method2()
        {
            using (var scope = Tracer.Instance.StartActive("method2"))
            {
                var span = scope.Span;
                span.Type = "custom";
                span.ResourceName = "TraceSample";

                return "Hello from method 2";
            }
        }
    }
}