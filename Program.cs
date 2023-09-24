using System.Security.Cryptography;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen!");
        List<Task> allTasks = new();
        string option;

        do
        {
            Console.WriteLine("Välj mellan följande alternativ:\n1.Lägg till sak att göra\n2.Visa saker du ska göra och huruvida de är färdiga\n3.Markera ett alternativ som färdigt\nOm ingen inmatning görs så fortsätter programmet");
            option = Console.ReadLine();
            {
                int choice = Convert.ToInt32(option);
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Vad vill du lägga till?");
                        Task thingy = new();
                        thingy.WannaDo = Console.ReadLine();
                        allTasks.Add(thingy);
                        break;

                    case 2:
                        int y = 1;
                        foreach (Task item in allTasks)
                        {
                            Console.WriteLine(y++ + ". " + item.WannaDo + " | " + item.Done);
                        }
                        break;

                    case 3:

                        for (int i = 0; i < allTasks.Count; i++)
                        {
                            Console.WriteLine(i + ". " + allTasks[i].WannaDo);
                        }
                        Console.WriteLine("Ange ett nummer för att markera tinget som färdigt");
                        string input = Console.ReadLine();
                        int index = Convert.ToInt32(input);
                        allTasks[index].SetDone();
                        break;
                }
            }
        }
        while (!string.IsNullOrWhiteSpace(option));
    }
}
