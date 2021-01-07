using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //00:40:22
            string input = "12:40:22AM";                    
            Console.WriteLine(TimeConversion(input));

            //////////////////////////////////////
            Console.WriteLine(DateTime.Parse(input).ToString("HH:mm:ss"));
            Console.ReadKey();
        }

        static string TimeConversion(string s)
        {
            string hour = s.Substring(0, 2); //00
            string format = s.Substring(8, 2); // format AM / PM

            string conversion = s.Substring(0, 8);

            //ELIMINATE 'AM' FOR HRS BETWEEN 01:00:00AM AND 11:59:00AM
            if (format.Equals("AM"))
            {
                if (hour.Equals("12"))
                {
                    int hourAM = int.Parse(hour) - 12;
                    conversion = conversion.Replace(hour, string.Format("{0:00}", hourAM));
                }
                else
                {
                    conversion = s.Substring(0, 8);
                }
            }
            else
            {
                //LEAVE THE NOON HOUR AS-IS, BIT REMOVE 'PM'
                if (hour.Equals("12"))
                {
                    conversion = s.Substring(0, 8);
                }
                //ADD 12 TO RHE HOURS BETWEEN 01:00:00PM AND 11:59:00PM AND ELIMINATE 'PM'
                else
                {
                    int hourPM = int.Parse(hour) + 12;
                    conversion = conversion.Replace(hour, string.Format("{0:00}", hourPM));
                }
            }

            return conversion;
        }
    }
}
