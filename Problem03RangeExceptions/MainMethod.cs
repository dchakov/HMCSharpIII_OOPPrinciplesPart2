using System;


namespace Problem03RangeExceptions
{
    class MainMethod
    {
        static void Main()
        {
            try
            {
                int number = 200;
                if (number<1 || number >100)
                {
                    throw new InvalidRangeExeption<int>("Invalid input", 1, 100);
                }
            }
            catch (InvalidRangeExeption<int> ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                DateTime date = new DateTime(1974, 10, 01);
                if (date < new DateTime(1977, 03, 11) || date > new DateTime(1980, 05, 15))
                {
                    throw new InvalidRangeExeption<DateTime>("Invalid date",
                        new DateTime(1977, 03, 11), new DateTime(1980, 05, 15));
                }

            }
            catch (InvalidRangeExeption<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
