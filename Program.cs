using System.Security.Cryptography;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen\nVälj mellan följande alternativ:\n1.Lägg till sak att göra\n2.Visa saker du ska göra och huruvida de är färdiga\n3.Markera ett alternativ som färdigt\nOm ingen inmatning görs så fortsätter programmet");
        List<Task> allTasks = new();
        string option = Console.ReadLine();
        while (!string.IsNullOrEmpty(option))
        {
            int choice = Convert.ToInt32(option);
            // int i = Convert.ToInt32(thingy.WannaDo);
            switch (choice)
            {
                case 1:
                    //lägg till saker i listan
                    Task thingy = new();
                    thingy.WannaDo = Console.ReadLine();
                    allTasks.Add(thingy);
                    break;

                case 2:
                    //listan skrivas ut samt om Done or not.
                    foreach (Task item in allTasks)
                    {
                        Console.WriteLine(item.WannaDo);
                    }
                    break;

                case 3:
                    //markera saker som Done
                    break;

            }

        }



    }
}
