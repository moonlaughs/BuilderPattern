using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public sealed class ImmutableClass
    {
        private const int _id = 1;
        private static string _note;

        public static int Id { get => _id; }
        public static string Note { get => _note; set => _note = value; }

        public ImmutableClass(string note)
        {
            Note = note;
        }

        public void getNote()
        {
            Console.WriteLine("My id: " + Id);
        }
    }
}
