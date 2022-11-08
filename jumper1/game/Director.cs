namespace jumper1.game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private string _userGuess = "";
        private int _destroy = 7;
        private string _stringReveal = "_____";
        private bool _correctWord;
        private int _deathCount = 0;
        private Parachute _parachute = new Parachute();
        private bool _isAlive = true;
        private bool _wrong_guess;
        private string _theWord = "";
        private Words _words = new Words();
        private TerminalService _terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _theWord = _words.RandomWord();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isAlive)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Calls the Parachute and first game command
        /// </summary>
        private void GetInputs()
        {
            
            _terminalService.WriteText($"Hint: {_stringReveal}");
            _terminalService.WriteText($"{_theWord}");
            _parachute.CallChute(_destroy);
            _userGuess = _terminalService.ReadText("Guess a letter [a-z]: ");
            _terminalService.WriteText("");
           
        }

        /// <summary>
        /// Gets guess, stand compares is it with the current random word.
        /// </summary>
        private void DoUpdates()
        {


            if (_deathCount == 4)
            {
                _isAlive = false;
            }
            void checkLetter(string _userGuess)
            {
                // If the character is in the current random word replaces dashed string at the right index
                if (_theWord.Contains(_userGuess))
                {
                    char[] ch = _stringReveal.ToCharArray();
                    char[] ch2 = _userGuess.ToCharArray();
                    for (int i = 0; i < _theWord.Length; i++)
                    {
                        if (_theWord[i] == _userGuess[0])
                        {
                            ch[i] = ch2[0];
                        }
                    }
                _stringReveal = new string(ch);
                    _wrong_guess = false;
                }

                else
                {
                    _wrong_guess = true;
                    if (_wrong_guess == true)
                    {
                        _destroy--;     
                        _deathCount++;
                    }
                        }
            }

            void gotWord()
            {
                if (_stringReveal == _theWord)
                {
                    _correctWord = true;
                }
                else
                {
                    _correctWord = false;
                }
            }
            checkLetter(_userGuess);
            gotWord();


        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            if (_correctWord == true)
            {
                _isAlive = false;
                _terminalService.WriteText($"You've guessed correctly and you win. The word is {_theWord}");
            }
            else if ((_isAlive == false) && (_correctWord == false))
            {
                _terminalService.WriteText($"You did not make it. The right word is {_theWord}");
            }
            else if (_wrong_guess == false)
            {
                _terminalService.WriteText("You've guessed the right letter, continue.\n");
                _terminalService.WriteText("");
            }
            else if (_wrong_guess == true)
            {
                _terminalService.WriteText("You've guessed the wrong letter, continue.\n");
                _parachute.removechute(_destroy);
                _terminalService.WriteText("");
                _terminalService.WriteText("");
            }
        }
    }
}