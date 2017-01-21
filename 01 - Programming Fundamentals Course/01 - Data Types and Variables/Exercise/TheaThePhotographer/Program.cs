using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondsToFilterPicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long secondsToUploadImage = long.Parse(Console.ReadLine());

            long filterTime = pictures * secondsToFilterPicture;
            long uploadTime = (long)Math.Ceiling(pictures * filterFactor / 100d) * secondsToUploadImage;
            long overallTime = filterTime + uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(overallTime);
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
