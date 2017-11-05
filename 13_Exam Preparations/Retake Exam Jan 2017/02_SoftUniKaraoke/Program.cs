using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniKaraoke
{
    static void Main()
    {
        List<string> listOfOfficialParticipants = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> listOfOfficialSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<Participant> listOfAllPerformers = new List<Participant>();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "dawn")
                break;

            string[] inputLineTokens = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string nameOfPerformer = inputLineTokens[0];
            string nameOfPerformedSong = inputLineTokens[1];
            string awardGivenByPublic = inputLineTokens[2];

            Participant newPerformer = new Participant() { Name = nameOfPerformer /*, Award = awardGivenByPublic*/ };

            foreach (var performer in listOfAllPerformers)
            {
                if (performer.Name != nameOfPerformer)
                    listOfAllPerformers.Add(newPerformer);
                else
                    performer.ListOfAwards.Add(awardGivenByPublic);
            }

        }

        Console.WriteLine(string.Join(", ", listOfAllPerformers));
    }
}
public class Participant
{
    public string Name { get; set; }
    //public string Award { get; set; }
    public List<string> ListOfAwards { get; set; }
    public int AwardCount
    {
        get
        {
            return ListOfAwards.Count;
        }
    }
    public List<string> ListOfUniqueAwards
    {
        get
        {
            return ListOfAwards.Distinct().ToList();
        }
    }
}

