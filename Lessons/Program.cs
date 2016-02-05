using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Testing 12345");
            Solution test = new Solution();
            //var testVal = test.solution(1041);
            //var testVal = test.solution(new int[]{3, 8, 9, 7, 6}, 3);
            var testVal = test.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            //var testVal = test.solution(new int[] { 5, 1, 0, 2, 7, 0, 6, 6, 1 }, new int[] { 1, 0, 7, 4, 2, 6, 8, 3, 9 }, 2);
        }
    }

    class Solution
    {
        public int solution4(int[] A, int[] B, int K)
        {
            if (A.Length != B.Length || A.Length == 0 || B.Length == 0
                || K == 0 || K > A.Length || K > B.Length)
            {
                return 0;
            }



            return 0;
        }

        public int solution(int[] A)
        {
            if (A.Length == 0 || (A.Length % 2) == 0)
                return 0;

            var unpairList = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (unpairList.Contains(A[i]))
                {
                    unpairList.Remove(A[i]);
                }
                else
                {
                    unpairList.Add(A[i]);
                }
            }

            return unpairList.First();
        }

        public int solution3B(int[] A)
        {
            if (A.Length == 0 || (A.Length % 2) == 0)
                return 0;

            var unPairedVal = 0;
            var pairsFound = false;
            var pairValues = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (pairValues.Contains(i))
                    continue;

                pairsFound = false;

                if (i < A.Length - 1)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {


                        if (A[i] == A[j])
                        {
                            pairsFound = true;
                            pairValues.AddRange(new List<int>() { i, j });
                            break;
                        }
                    }
                }

                if (pairsFound == false) // unmatched value found
                {
                    unPairedVal = A[i];
                    break;
                }
            }
            return unPairedVal;
        }

        public int solution3A(int[] A)
        {
            if (A.Length == 0 || (A.Length % 2) == 0)
                return 0;

            var listA = A.ToList();
            while (listA.Count > 1)
            {
                var pairVal = listA.First();
                var pairIdx = 0;
                for (int i = 1; i < listA.Count; i++)
                {
                    if (pairVal == listA[i])
                    {
                        pairIdx = i;
                        break;
                    }
                }

                listA.RemoveAt(0);
                listA.RemoveAt(pairIdx - 1);
            }

            return listA.First();
        }

        public int[] solution2(int[] A, int K)
        {
            var startIdx = 0;

            for (int i = 0; i < K; i++)
            {

                if (startIdx == A.Length - 1)
                    startIdx = 0;
                else
                    startIdx++;
            }

            var rotateAIdx = startIdx;
            var rotatedA = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (rotateAIdx == rotatedA.Length && i != 0)
                    rotateAIdx = 0;

                rotatedA[rotateAIdx] = A[i];
                rotateAIdx++;
            }

            return rotatedA;
        }

        public int solution1(int N)
        {
            if (N <= 0)
                return 0;

            var binaryStrN = Convert.ToString(N, 2).Trim();
            var gapList = binaryStrN.Split(new char[] { '1' });
            var longestGap = string.Empty;
            for (int i = 0; i < gapList.Count(); i++)
            {
                if (gapList[i].Length > longestGap.Length)
                {
                    if (i == gapList.Length - 1)
                    {
                        if (binaryStrN[binaryStrN.Length - 1] != '1')
                        {
                            break;
                        }
                    }
                    longestGap = gapList[i];
                }

            }

            return longestGap.Length;
        }
    }

}
