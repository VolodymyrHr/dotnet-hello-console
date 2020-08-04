using System;

namespace hello_console
{
    class Program
    {
        static void Main()
        {
            DateTime start = new DateTime(2020, 7, 1);
            DateTime end = new DateTime(2020, 3, 30);
            DateTime[] holiday = {new DateTime(2020, 3, 12), new DateTime(2020, 3, 20)};

            Console.WriteLine(CountWorkingDays(start, end, holiday));
        }
        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holiday)
        {
            int countday = 0;

            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                // for(var i=0; i<holiday.Length; i++){
                //     Console.WriteLine(dt);
                //     if(dt == holiday[i]){
                //         countday++;
                //     }
                // }
                if(!Array.Exists(holiday, element => element.Equals(dt))){
                    countday++;
                }
            }

            return countday;
        }

    }
}
