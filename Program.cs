using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DotNet.Utilities;
using System.Media;

namespace wavHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaHandler m = new MediaHandler();
            MediaHandler.SyncPlayWAV("D:\\Users\\marc\\Documents\\Visual Studio 2012\\Projects\\wavHandler\\wavHandler\\test.wav");
            
            Console.WriteLine("Hello Media Wav!");
        }
    }
}
