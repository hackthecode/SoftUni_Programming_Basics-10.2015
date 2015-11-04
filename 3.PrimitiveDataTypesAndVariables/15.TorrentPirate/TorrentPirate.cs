using System;

namespace _15.TorrentPirate
{
    class TorrentPirate
    {
        static void Main()
        {
            int downloadData = int.Parse(Console.ReadLine());
            int priceOfCinema = int.Parse(Console.ReadLine());
            int moneyPerHours = int.Parse(Console.ReadLine());

            double downloadTime = (double)downloadData / 2 / 60 / 60;
            double costAtMall = downloadTime * moneyPerHours;
            double numberOfMovies = (double)downloadData / 1500;
            double costAtCinema = numberOfMovies * priceOfCinema;

            if (costAtMall > costAtCinema)
            {
                Console.WriteLine("cinema -> {0:0.00}lv", costAtCinema);
            }
            else
            {
                Console.WriteLine("mall -> {0:0.00}lv", costAtMall);
            }
        }
    }
}
