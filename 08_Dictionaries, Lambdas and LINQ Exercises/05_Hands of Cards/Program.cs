using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> namesAndAllCards = new Dictionary<string, List<string>>();
            Dictionary<string, long> results = new Dictionary<string, long>();

            string command = Console.ReadLine();
            long peshoScore = 0;
            long slovScore = 0;
            long peshoslavScore = 0;

            while (command != "JOKER")
            {
                List<string> nameAndCards = command.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> cards = nameAndCards.Last().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //A single person cannot have more than one card with the same power and type, if they draw such a card they discard it

                if (namesAndAllCards.Keys.Contains(nameAndCards.First()))
                    namesAndAllCards[nameAndCards.First()].AddRange(cards);
                else
                    namesAndAllCards.Add(nameAndCards.First(), cards);

                foreach (var keyValuePair in namesAndAllCards)
                    keyValuePair.Value.Distinct();

                foreach (var listOfCards in namesAndAllCards.Values)
                {
                    List<long> cardsScores = new List<long>();
                    foreach (var card in listOfCards)
                    {
                        long cardscore = 0;
                        long power = 0;
                        long multiplier = 0;

                        if (card.First() == '2')
                            power = 2;
                        else if (card.First() == '3')
                            power = 3;
                        else if (card.First() == '4')
                            power = 4;
                        else if (card.First() == '5')
                            power = 5;
                        else if (card.First() == '6')
                            power = 6;
                        else if (card.First() == '7')
                            power = 7;
                        else if (card.First() == '8')
                            power = 8;
                        else if (card.First() == '9')
                            power = 9;
                        else if (card.First() == '1')
                            power = 10;
                        else if (card.First() == 'j')
                            power = 11;
                        else if (card.First() == 'q')
                            power = 12;
                        else if (card.First() == 'k')
                            power = 13;
                        else if (card.First() == 'a')
                            power = 14;

                        if (card.Last() == 's')
                            multiplier = 4;
                        else if (card.Last() == 'h')
                            multiplier = 3;
                        else if (card.Last() == 'd')
                            multiplier = 2;
                        else if (card.Last() == 'c')
                            multiplier = 1;

                        cardscore = power * multiplier;
                        cardsScores.Add(cardscore);
                    }
                    
                }

                long currsumofcardscores = cardsScores.sum();
                string currplayername = nameandcards.first();

                if (results.keys.contains(currplayername))
                {
                    results[currplayername] += currsumofcardscores;
                }
                else
                    results.add(currplayername, currsumofcardscores);

                command = Console.ReadLine();
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
//Dictionary<string, List<string>> listOfPlayers = new Dictionary<string, List<string>>();

//List<string> powers = new List<string>();
//List<string> multipliers = new List<string>();

//                for (int i = 1; i <= cards.Count; i++)
//                {
//                    if (i % 2 == 1)
//                        powers.Add(cards[i]);
//                    else
//                        multipliers.Add(cards[i]);
//                }

//                string nameOrKeyToAdd = nameAndCards.First();
//List<string> cardsOrValueToAdd = cards;
//List<long> cardsScores = new List<long>();

//                foreach (var card in cards)
//                {
