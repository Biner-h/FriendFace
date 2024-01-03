using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class Profile
    {
        private string Name {  get; set; }
        private string Nickname { get; set; }
        private int Age { get; set; }
        private string Education { get; set; }
        private string Work {  get; set; }
        private string PlaceOfLiving { get; set; }

        public Profile(string name, string nickname, int age, string education, string work, string placeofliving) 
        {
            Name = name;
            Nickname = nickname;
            Age = age;
            Education = education;
            Work = work;
            PlaceOfLiving = placeofliving;
        }

        public Profile() { }

        public void GenerateProfile()
        {
            Console.WriteLine("FriendFace - lag en profil.");
            Console.WriteLine("Hva heter du?");
            Name = Console.ReadLine();
            Console.WriteLine("Hva er brukernavnet ditt?");
            Nickname = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hvor gikk du på skole?");
            Education = Console.ReadLine();
            Console.WriteLine("Hva jobber du som?");
            Work = Console.ReadLine();
            Console.WriteLine("Hvor bor du?");
            PlaceOfLiving = Console.ReadLine();
        }

        public string GetName()
        {
            return Name;
        }

        public string GetNickname()
        {
            return Nickname;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetEducation()
        {
            return Education;
        }

        public string GetWork()
        {
            return Work;
        }

        public string GetPlaceOfLiving()
        {
            return PlaceOfLiving;
        }
    }
}
