using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.Communications.Common.Telemetry;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using Sample.AudioVideoPlaybackBot.FrontEnd;
using TBot.AudioVideoPlaybackBot.FrontEnd.Bot;
using TBot.Common.Entity;

namespace WorkerRole1
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

        public override void Run()
        {
            Trace.TraceInformation("WorkerRole1 is running");

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at https://go.microsoft.com/fwlink/?LinkId=166357.

            // Create and start the environment-independent service.
            Service.Instance.Initialize(new GraphLogger());
            Service.Instance.Start();


            bool result = base.OnStart();

            Trace.TraceInformation("WorkerRole1 has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("WorkerRole1 is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("WorkerRole1 has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {

            //JoinCallBody data = new JoinCallBody()
            //{
            //    JoinURL = "https://teams.microsoft.com/l/meetup-join/19%3a35a466cd6e2d4efda6df1ab5456ec170%40thread.tacv2/1595884031503?context=%7b%22Tid%22%3a%2209c8b911-b715-46dc-a14e-a547989bad27%22%2c%22Oid%22%3a%2287bfe48d-53e2-42c9-af53-50c03ae06611%22%7d"
            //};
            //var call = await Bot.Instance.JoinCallAsync(data).ConfigureAwait(false);

            // TODO: Replace the following with your own logic.
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");
                await Task.Delay(1000);
            }
        }
    }
}
