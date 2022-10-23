using System;
using System.Collections.Generic;


namespace jumper1.game
{



    public class Parachute
    {
        string[] _characters = Array.Empty<string>();
        List<string> _gameCharacters = new List<string>();


        public Parachute()
        {
            string[] _characters = { " ___", @"/___\", @"\   /", @" \ /", @"  O", @" /|\", @" / \" };
            _gameCharacters = new List<string>(_characters);
        }


        public void CallChute()
        {

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(_gameCharacters[i]);
            }
        }

    }

}