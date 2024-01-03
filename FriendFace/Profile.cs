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

        public Profile(string name, string nickname, int age, string education, string work, string placeofliving) { }
    }
}
