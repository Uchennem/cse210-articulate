using System;
using System.Collections.Generic;


namespace hilo.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        int _cardNow = 0;
        bool _isPlaying = true;
        public string _guessCard = "";
        int _score = 300;

        Card _card= new Card();

        int randomNumber = 0;


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {

        }
        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                DisplayRandom();
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they for an input.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Higher or Lower? [h/l]: ");
            _guessCard = Console.ReadLine();
            _isPlaying = true;
        }

        public void DisplayRandom()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 14);

            Console.Write($"The card is: {randomNumber}");
            Console.WriteLine();
            _cardNow = _card.CurrentCard();

        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (((string.Equals(_guessCard, "l")) && (randomNumber > _cardNow)) || ((string.Equals(_guessCard, "h")) && (randomNumber < _cardNow)))
            {
                _score += 100;
            }

            else
            {
                _score -= 75;
            }

        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            Console.Write($"Next card was: {_cardNow}");
            Console.WriteLine();
            Console.Write($"Your score is: {_score}");
            Console.WriteLine();

            Console.Write("Play again? [y/n]: ");
            string playAgain = Console.ReadLine();
            Console.WriteLine();

            if (string.Equals(playAgain, "n"))
            {
                _isPlaying = false;
            }

            else
            {
                _isPlaying = true;
            }
        }

    }
}