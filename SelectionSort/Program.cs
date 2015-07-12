using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array= new int[] {5, 1, 7, 10, 3,2};
            SelectionSort(array, array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }
           
        }

        public static void SelectionSort(int[] array, int lenthOfArray)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                int j;
                for ( j = i + 1; j < array.Length;j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            
        }
    }


}
   

