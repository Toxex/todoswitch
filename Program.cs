using System.Security.Cryptography;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen\nVälj mellan följande alternativ:\n1.Lägg till sak att göra\n2.Visa saker du ska göra och huruvida de är färdiga\n3.Markera ett alternativ som färdigt\nOm ingen inmatning görs så fortsätter programmet");
        List<Task> allTasks = new();
        Task thingy = new();
        thingy.WannaDo = Console.ReadLine();

        while (!string.IsNullOrEmpty(thingy.WannaDo))
        {
            thingy.Choice = Convert.ToInt32(thingy.WannaDo);
            // int i = Convert.ToInt32(thingy.WannaDo);
            switch (thingy.Choice)
            {
                case 1:

                    break;

                case 2:
                    //listan skrivas ut samt om Done or not.
                    break;

                case 3:
                    //markera saker som Done
                    break;

            }
        }


    }
}
