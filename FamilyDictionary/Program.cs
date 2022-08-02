namespace FamilyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define a dictionary

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("sister2", new Dictionary<string, string>() { { "name", "Becky" }, { "age", "22" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Bob" }, { "age", "72" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Martha" }, { "age", "67" } });



            foreach (var family in myFamily)
                    {
                Console.WriteLine($"{family.Value["name"]} is my {family.Key} and is {family.Value["age"]}");
            }


            Console.WriteLine(myFamily["sister"]["name"]);

            Console.WriteLine(myFamily["sister"]);
            Console.ReadLine();
        }
    }
}