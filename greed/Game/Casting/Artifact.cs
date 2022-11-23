namespace greed.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    class Artifact : Actor
    {
        private int _artifact;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
            _artifact = 0;
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public int GetMessage()
        {
            return _artifact;
        }

        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        
    }
}
