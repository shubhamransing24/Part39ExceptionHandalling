using System;
using System.IO;

namespace Part39ExceptionHandalling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
         try
            {
                reader = new StreamReader("E:\\New folder\\data.txt");
                Console.WriteLine(reader.ReadToEnd());
               

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }

                Console.WriteLine("Finally Block always Executes");
            }

        }
    }
}
