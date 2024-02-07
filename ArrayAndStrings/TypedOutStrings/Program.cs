using System.Text;

namespace TypedOutStrings
{
    internal class Program
    {
        // given two strings S and T , return if they equal when both are typed out.Any '#' that apepars in the string counts as a backspace
        // Example:   S= "ab#c" output : "ac" , T="az#c" output : "ac

        // Constraints-1 : what happens when two "#" appear beside each other? --> Delete the two values before the first #. 
        // Example "ab##" output : ""

        // Constraints-2 : what happens to 3 when there is no character to remove ? --> it delets nothing then, just like backspace would.
        // Example : "a###b" output: "b"

        // Are two empty strings equal to each other? --> yes consider two empty strings as equal
        // Does case sensitivity matter? --> yes it does. "a" doesnt equal "A".

        static void Main(string[] args)
        {
            return ProcessString(s) == ProcessString(t);
        }

        static string ProcessString(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (c == '#')
                {
                    if (result.Length > 0)
                    {
                        result.Length--; // Backspace, remove the last character
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
