using System;
using System.Collections.Generic;


namespace jumper1.game
{



    public class Parachute
    {
        private string[] _characters = { " ___", @"/___\", @"\   /", @" \ /", @"  O", @" /|\", @" / \" };
        private List<string> _gameCharacters = new List<string>();

        public Parachute()
        {
            _gameCharacters = new List<string>(_characters);
        }


        public void CallChute(int b)
        {

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(_gameCharacters[i]);
            }
        }

        public void removechute(int d)
        {
            _gameCharacters.RemoveAt(0);
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine(_gameCharacters[i]);
            }
        }

    }

}