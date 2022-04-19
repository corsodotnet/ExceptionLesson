using System;

namespace ExceptionLesson
{
    public class Demo
    {
        public Demo()
        {

        }
        public int GrandparentMethod(int position)
        {
            int output = 0;
            // 5000+ 
            try
            {
                Console.WriteLine("Apri connessione al DB");
                output = ParentMethod(position); // -> Crash
                Console.WriteLine(" Write user to DB");

            }
            catch (DivideByZeroException ex)
            {

            }
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (Exception ex)
            {

                //Log.write();// Administrator
                throw;
            }
            finally
            {
                Console.WriteLine("Close connection"); // -> connection opened

            }
            return output;
        }
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            // -> Divisione
            // 
            int output = 0;


            // leggere da un Array
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];



            return output;
        }

    }
}
