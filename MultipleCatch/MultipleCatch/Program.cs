using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "a", "b", "c", "d", "e" };
            try
            {
                Console.WriteLine(list[5]);
                try
                {
                    Console.WriteLine(list[4]);
                    Console.WriteLine("Hello World!");
                }
               
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Ouside Indexoutofbound catch:" + ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Ouside ArgumentOutOfRange catch:" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Inside catch:" + ex.Message);
                }
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Ouside Arithmetic catch:"+ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Ouside  Null catch:" + ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ouside Indexoutofbound catch:" + ex.Message);
            } 
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ouside ArgumentOutOfRange catch:" + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ouside Exception catch:" + ex.Message);
            }
           
        
        }
    }
}
