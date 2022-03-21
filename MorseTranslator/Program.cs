using System.Text.RegularExpressions;

// The programs input and output
string input = "";
string output = "";

Console.WriteLine("Input your morse code (letters only).\nUse double space or / to separate words: ");

// Continue taking text input until user inputs pure morse code
do
{
    input = Console.ReadLine();
} while (Regex.IsMatch(input, @"[^-. /]+$"));

// Split users input into an array of morse-encoded letters
string[] morse = input.Split(' ');

// Translate each letter to the latin alphabet
foreach (string letter in morse)
{
    output += GetMorseLetter(letter);
}

// Write the output to console
Console.WriteLine(output);

/// <summary>
/// Translates a string from morse code to the latin alphabet.
/// Based on this chart: https://commons.wikimedia.org/wiki/File:Morse-code-tree.svg (letters only).
/// </summary>
char GetMorseLetter(string s)
{
    switch (s.Length)
    {
        case 0:
            return ' '; // Empty strings can also be used to separate words.
        case 1:
            switch (s[0])
            {
                case '.':
                    return 'E';
                case '-':
                    return 'T';
                case '/': // Forward slash is used to separate words.
                    return ' ';
                default:
                    throw new ArgumentException("Unexpected input.");
            }

        case 2:
            switch (s[0])
            {
                case '.':
                    switch (s[1])
                    {
                        case '.':
                            return 'I';
                        case '-':
                            return 'A';
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                case '-':
                    switch (s[1])
                    {
                        case '.':
                            return 'N';
                        case '-':
                            return 'M';
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                default:
                    throw new ArgumentException("Unexpected input.");
            }

        case 3:
            switch (s[0])
            {
                case '.':
                    switch (s[1])
                    {
                        case '.':
                            switch (s[2])
                            {
                                case '.':
                                    return 'S';
                                case '-':
                                    return 'U';
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        case '-':
                            switch (s[2])
                            {
                                case '.':
                                    return 'R';
                                case '-':
                                    return 'W';
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                case '-':
                    switch (s[1])
                    {
                        case '.':
                            switch (s[2])
                            {
                                case '.':
                                    return 'D';
                                case '-':
                                    return 'K';
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }

                        case '-':
                            switch (s[2])
                            {
                                case '.':
                                    return 'G';
                                case '-':
                                    return 'O';
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                default:
                    throw new ArgumentException("Unexpected input.");
            }

        case 4:
            switch (s[0])
            {
                case '.':
                    switch (s[1])
                    {
                        case '.':
                            switch (s[2])
                            {
                                case '.':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'H';
                                        case '-':
                                            return 'V';
                                        default:
                                            throw new ArgumentException("Unexpected input.");
                                    }
                                case '-':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'F';
                                        default:
                                            throw new Exception("Unexpected input.");
                                    }
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        case '-':
                            switch (s[2])
                            {
                                case '.':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'L';
                                        default:
                                            throw new Exception("Unexpected input.");
                                    }
                                case '-':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'P';
                                        case '-':
                                            return 'J';
                                        default:
                                            throw new ArgumentException("Unexpected input.");
                                    }
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                case '-':
                    switch (s[1])
                    {
                        case '.':
                            switch (s[2])
                            {
                                case '.':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'B';
                                        case '-':
                                            return 'X';
                                        default:
                                            throw new ArgumentException("Unexpected input.");
                                    }
                                case '-':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'C';
                                        case '-':
                                            return 'Y';
                                        default:
                                            throw new ArgumentException("Unexpected input.");
                                    }
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }

                        case '-':
                            switch (s[2])
                            {
                                case '.':
                                    switch (s[3])
                                    {
                                        case '.':
                                            return 'Z';
                                        case '-':
                                            return 'Q';
                                        default:
                                            throw new ArgumentException("Unexpected input.");
                                    }
                                default:
                                    throw new ArgumentException("Unexpected input.");
                            }
                        default:
                            throw new ArgumentException("Unexpected input.");
                    }
                default:
                    throw new ArgumentException("Unexpected input.");
            }
        default:
            throw new ArgumentException("Unexpected input.");
    }
}