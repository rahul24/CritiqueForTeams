using Microsoft.Graph.Communications.Common.Telemetry;
using Sample.AudioVideoPlaybackBot.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Service.Instance.Initialize(new GraphLogger());
            Service.Instance.Start();
            Console.ReadKey();
        }
    }
}
