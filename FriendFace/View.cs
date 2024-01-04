using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class View
    {
        public List<Profile> Profiles { get; set; }

        public View(List<Profile> list) 
        {
            Profiles = list;
        }

        public void ShowFriendMenu()
        {
            for (int i = 0; i < Profiles.Count; i++)
            {
                Console.WriteLine($"{i}.{Profiles[i].GetName()} {Profiles[i].GetNickname()}");
            }
        }

        public void ShowFriends()
        {
            for (int i = 0; i < Profiles.Count; i++)
            {
                Console.WriteLine($"{Profiles[i].GetName()} {Profiles[i].GetNickname()} {Profiles[i].GetAge()} {Profiles[i].GetEducation()} {Profiles[i].GetWork()} {Profiles[i].GetPlaceOfLiving()}");
            }
        }

        public void RemoveFriend()
        {

        }

        public void menu()
        {
            var profile = new Profile();

            profile.GenerateProfile();

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ShowFriendMenu(); break;
                case "2":
                     break;
                case "3":
                    RemoveFriend(); break;
                case "4":
                    ShowFriends(); break;
                default: break;
            }
        }
    }
}
