using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Text;
using w2_EnhanncedFileIO.Services;

namespace w1_in_class
{
    public class Program

    {
        static void Main()
        {


            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Level Up Character");
            Console.WriteLine("-----------------------");


            var menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
               CharacterManager.DisplayCharacters();

            }

            if (menuOption == "2")
            {
                CharacterManager.AddCharacter();

            }

            if (menuOption == "3")
            {
                CharacterManager.LevelUpCharacter();

            }



        }
       

    }
  
}