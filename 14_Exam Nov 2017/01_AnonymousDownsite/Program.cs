using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class AnonymousDownsite
{
    static void Main()
    {
        //input
        int N = int.Parse(Console.ReadLine());
        long securityKey = long.Parse(Console.ReadLine());
        //Dictionary<string, decimal> sitesLosses = new Dictionary<string, decimal>();
        List<string> listOfSites = new List<string>();
        decimal totalLoss = 0m;

        for (int i = 0; i < N; i++)
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string siteName = inputLine[0];
            long siteVisits = long.Parse(inputLine[1]);
            decimal siteCommercialPricePerVisit = decimal.Parse(inputLine[2]);

            var siteLoss = siteVisits * siteCommercialPricePerVisit;
            totalLoss += siteLoss;

            listOfSites.Add(siteName);
        }
        var securityToken = RaiseToPower(securityKey, N);//Math.Pow(securityKey, N) here we cannot put this in a double, so use something else that is not math pow, write your own method, maybe

        //output
        for (int i = 0; i < listOfSites.Count; i++)
        {
            Console.WriteLine(listOfSites[i]);
        }
        Console.WriteLine($"Total Loss: {totalLoss:F20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }

    private static BigInteger RaiseToPower(long n, int pow)
    {
        BigInteger numberToPower = 1;

        for (int i = 0; i < pow; i++)
        {
            numberToPower = numberToPower * n;
        }
        return numberToPower;
    }
}

