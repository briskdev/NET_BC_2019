using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_ERRHNDL
{
    class Program
    {

        static void Main(string[] args)
        {
            UserList list = new UserList();
            list.Add("asdasd", UserProfile.Genders.Female, DateTime.Now);
            list.Add("34dsdasd", UserProfile.Genders.Female, DateTime.Now);

            UserList list2 = new UserList();
            list2.Add("dadsasdsad", UserProfile.Genders.Female, DateTime.Now);
            list2.Add("sadrggfg", UserProfile.Genders.Female, DateTime.Now);











            try
            { 
                UserList list = new UserList();

                // 1. cikliski vaicā pievienot lietotājus
                while(true)
                {
                    try
                    { 
                        // 1.1. Ievada vārdu
                        string name = ConsoleInput.GetText("Enter name: ");
                        // 1.2. Ievada datumu (DateTime.TryParse)
                        DateTime birthDate = ConsoleInput.GetDate("Enter birth date: ");
                        // 1.3. Ievada dzimumu (Enum.TryParse)
                        UserProfile.Genders gender = GetGender();

                        // 2. Izsauc lietotāja pievienošanu ar vērtībām augstāk
                        list.Add(name, gender, birthDate);
                        // 3. Ja neizdevās pievienot, attēlo kļūdas paziņojumu 
                        //    un sāk 1. soli no jauna

                        Console.Write("Add another? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if(input == "n")
                        {
                            break;
                        }
                    }
                    catch(InputException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected error! {0}", ex.Message);
            }

            Console.Read();
        }

        

        public static UserProfile.Genders GetGender()
        {
            Console.Write("Enter gender: ");
            string value = Console.ReadLine();

            if(Enum.TryParse(value, true, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value!");
                return GetGender();
            }
        }
    }
}
