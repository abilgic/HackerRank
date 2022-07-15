using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    internal class Result
    {/*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int diagonalDifference(List<List<int>> arr)
        {
            var ldiagonal = 0;
            var rdiagonal = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                ldiagonal += arr[i][i];                
                rdiagonal += arr[i][arr.Count - i - 1];
            }

            var absdif = Math.Abs(ldiagonal - rdiagonal);
            return absdif;
        }
    }
}
