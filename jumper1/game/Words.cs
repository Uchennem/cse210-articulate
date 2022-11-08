using System;
using System.Collections.Generic;
// using jumper1.game;

namespace jumper1.game
{

    public class Words
    {

        private string[] _lines = Array.Empty<string>();
        private List<string> _words;
        private int _value = 0;
        private string _word ="";


// Creates a list of 500 5 letter words.
        public Words ()
        {
            _lines = System.IO.File.ReadAllLines(@"C:\cse210-articulate\jumper1\game\text.txt");
            _words = new List<string>(_lines);
        }


// Gets a random word from the list
        public string RandomWord()
        {
            List<string> _words = new List<string>(_lines);
            Random random = new Random();
            _value = random.Next(500);
             _word = _words[_value];

            return (_word);
        }

        public int getWordCount(string word)
        {
            int word_count = word.Length;
            return word_count;
        }

    }


}