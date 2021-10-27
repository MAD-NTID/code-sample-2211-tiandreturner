using System;

namespace PracticePractical2 { 
    public static class Utility
    {
        /// <summary>
        /// Utility display routine -- displays text message in selected color
        /// </summary>
        /// <param name="_msg">Message to display</param>
        /// <param name="_color">Display color</param>
        /// <param name="_newLine">Determines if new line should follow the output.  Default is true (new line)
        /// must explicitly state false to stay on same line</param>
        public static void DisplayText( string _msg, ConsoleColor _color, bool _newLine = true) {
            Console.ForegroundColor = _color;
            Console.Write ( _newLine ? _msg + "\n" : _msg );
            Console.ResetColor();
        }

    }
}