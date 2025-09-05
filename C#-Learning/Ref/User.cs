using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Ref
{
    internal class User
    {
        private readonly int _id;
        private string _name;


        public User(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id => _id;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
