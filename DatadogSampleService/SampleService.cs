using System.ServiceProcess;

namespace DatadogSampleService
{
    public partial class SampleService : ServiceBase
    {
        public SampleService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}