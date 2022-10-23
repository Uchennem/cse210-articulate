using System;
using System.Collections.Generic;
// using jumper1.game;

namespace jumper1.game
{

    public class Words
    {

        public string[] _lines = Array.Empty<string>();
        public List<string> _words;
        public int _value = 0;
        public string _word ="";

        public Words ()
        {
            _lines = System.IO.File.ReadAllLines(@"C:\cse210-articulate\jumper1\game\text.txt");
            _words = new List<string>(_lines);
        }



        public void RandomWord()
        {
            List<string> _words = new List<string>(_lines);
            Random random = new Random();
            _value = random.Next(501);
             _word = _words[_value];

            Console.WriteLine(_word);
        }

    }


}