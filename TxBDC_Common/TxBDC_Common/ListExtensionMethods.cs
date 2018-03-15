using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxBDC_Common
{
    public static class ListExtensionMethods
    {
        /// <summary>
        /// Shuffles a list so elements are in random order
        /// </summary>
        /// <param name="original_list">The original, unshuffled list</param>
        /// <returns>A shuffled list with elements in random order</returns>
        public static List<T> ShuffleList<T>(this List<T> original_list)
        {
            //Copy the original list.
            List<T> result = original_list.ToList();
            
            var random = RandomNumberStatic.RandomNumbers;

            int n = result.Count;
            while (n > 1)
            {
                n--;
                int i = random.Next(n + 1);
                T temp = result[i];
                result[i] = result[n];
                result[n] = temp;
            }

            return result;
        }
    }
}
