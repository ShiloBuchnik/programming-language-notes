using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literals_constants_variables
{
    class Program
    {
        // variable
        //        <data_type> <constant_name> = value;
        double something = 0;

        // constants
        //  const <data_type> <constant_name> = value;
        const double pi = 3.14159;


        // literals
        //      some are given as
        //          values on right side of below variables & constants

        decimal d = 85;     /* decimal */

        int i = 30;         /* int */

        // prefix specifies the base or radix
        int ih = 0x4b;      /* hexadecimal */

        // suffix - combination of U and L, for unsigned and long
        uint ui = 30u;      /* unsigned int */
        long l = 30L;       /* long */  // better CAPS L
        // long l = 30l;       /* long */  // not recommended LOWER l
        ulong ul = 30ul;    /* unsigned long */

        // floating-point literal
        //
        //  represents either in
        //      decimal form or
        //      exponential form
        //  has
        //      integer part
        //      decimal point
        //      fractional part, and
        //      exponent part

        double d01 = 314159; /* Legal */
        double d02 = 314159.0; /* Legal */
        double d1 = 3.14159; /* Legal */
        double d2 = 314159E-5F; /* Legal */     // integer part E fractional part
                                                // double d3 = 510E; /* Illegal: incomplete exponent */
                                                // double d4 = 210f; /* Illegal: no decimal or exponent */
                                                // double d5 = .e55; /* Illegal: missing integer or fraction */

        // Character literals
        //  enclosed in single quotes

        char ch1 = 'x';         // plain character
        char ch2 = '\t';        // escape sequence
        char ch3 = '\u02C0';    // universal character

        /*
Escape sequence	    Meaning
\n	                Newline
\r	                Carriage return
\t	                Horizontal tab
\v	                Vertical tab
\b	                Backspace
\f	                Form feed
\\	                \ character         '\\'
\'	                ' character         '\''
\"	                " character         "\""
\?	                ? character
\a	                Alert or bell
\xhh . . .	        Hexadecimal number of one or more digits        0x4b    \x4b
*/


        static void f1(long x)
        {
        }

        static void Main(string[] args)
        {

            // String literals or constants
            //      enclosed in double quotes "" or with @""

            string s1 = "hello, dear";
            string s2 = @"hello dear";
            string s3 = @"hello
dear";
            string s4 = @"hello, ""
dear";
            /*
string s5 = "hello, \
dear");
string s6 = "hello, " "d" "ear";
            */

            f1(30L);
        }
    }
}
