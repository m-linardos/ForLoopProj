using System;

namespace ForLoopProj {
    class Program {
        static void Main(string[] args) {
            
            int[] ints =  { 89, 188, 295, 943, 975, 277, 119, 736, 952, 321, 521, 444, 758,
                    397, 915, 878, 674, 701, 379, 331, 804, 461, 459, 908, 373 };
            int total = 0;

           

            /**** for 
            //for (int idx = 0; idx < ints.Length; idx++) {
            //    /* total += ints[idx]; */
            //    /* total += ints[idx] * 2; */
            //    total += ints[idx]  * 3/4;
            //}

            foreach (int Fred in ints) {        // type - 'int', made up variable - 'Fred', in - 'in'(always used), collection used - 'ints'
                total += Fred;                 // body the same except 'anInt' replaces 'ints[idx] / does the same
            }


            decimal average = total / (decimal) ints.Length;     //just for this one line, cast ints.Length as decimal
            //decimal average = total / ints.Length;
            Console.WriteLine($"Total: {total}, Agerage: {average}");


            // FOREACH LOOP //                                                        // USE IN PRS CAPSTONE
            // Use foreach loops the most for collections //


            /*** change names[] to all lower case ***/     //Uae variable to convert names / use foreach loop
                                                           /***/
            string[] names = { "Brailee", "Briana", "Marianne", "Maggie", "Glenn", "Alex", "Jesse", "Titus" };

          

            string allNames = "";                          // create empty string for collection/ plural

            foreach (string name in names) {

                string upperName = name.ToUpper();         // make upper case

                allNames += upperName;                     //  same as allNames = allNames + upperName 
                                                           // concatonates each name in collection with name.TuUpper               
            }

            Console.WriteLine(allNames);

            /***/

        }
    }
}
