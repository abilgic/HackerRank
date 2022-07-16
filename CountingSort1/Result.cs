using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort1
{
    class Result
    {

        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static List<int> countingSort(List<int> arr)
        {
            int[] resultList = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                resultList[arr[i]]++;
            }
            return resultList.ToList();
        }
        //public static List<int> countingSort(List<int> arr)
        //{
        //    int[] resultList = new int[100];

        //    foreach (var i in arr)
        //    {
        //        resultList[i]++;

        //    }

        //    return resultList.ToList();
        //}
        //public static List<int> countingSort(List<int> arr)
        //{
        //    int[] resultList = new int[arr.Count];

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        var element = i;
        //        resultList[i] = arr.Count(a => a == element);
        //        //Console.Write($"{element}={resultList[i]} ");               
        //    }

        //    //for (int i = 0; i < arr.Count; i++)
        //    //{
        //    //    Console.Write($"{resultList[i]} ");
        //    //}

        //    return resultList.ToList();
        //}
        //public static List<int> countingSort(List<int> arr)
        //{
        //    var dict = new Dictionary<int, int>();

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (!dict.ContainsKey(arr[i]))
        //        {
        //            dict.Add(arr[i], 1);
        //        }
        //        else if (dict.ContainsKey(arr[i]))
        //        {
        //            dict[arr[i]]++;
        //        }
        //    }
        //    //foreach (var i in dict) { Console.Write($"{i.Value} "); }

        //    int[] resultList = new int[arr.Count];
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (dict.ContainsKey(i))
        //        {
        //            resultList[i] = dict[i];
        //        }
        //        else
        //        {
        //            resultList[i] = 0;
        //        }
        //    }
        //    return resultList.ToList();
        //}
    }
}
