
using System;


namespace Task1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam.\nUsername daxil edin:");
            string username = Console.ReadLine();

            Console.WriteLine("Alindi.\nPasswordunuzu daxil edin:");
            string password = Console.ReadLine();

            Console.WriteLine("Duzdu.\nEmailinizi daxil edin:");
            string email = Console.ReadLine();

            User user = new User(username, password);

            user.Fullname = $"Salam {username} {email}";
            
            Console.WriteLine("Hormetli istifadeci, girishiniz tamamlanmishdir!\n___________________________________________");

            //Console.WriteLine(user.Fullname);

            Console.WriteLine(user.ShowInfo());
            // Hemid muellim uzr isteyirem amma passwordchecker methodunda nese sehv buraxmisham, hec cure basha dushe bilmirem nedi
            // hetta recordlara oturub baxiram butun using-leri, implementleri etdim, yeqin sadece hardasa balaca sehv var...
            // Teshekkur edirem
        }
    }
}
