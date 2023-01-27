using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primaryList = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    primaryList.Add(i);
                }
            }
            return primaryList;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static int IsInOrder(int a, int b)
        {
            int orderCheck = b - a;
            switch (orderCheck)
            {
                case < 0:
                    return -1;
                case > 0:
                    return 1;
                default:
                    return 0;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            int direction = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (i == 0)
                {
                    direction = IsInOrder(list[i], list[i + 1]);
                }
                if (IsInOrder(list[i], list[i + 1]) != direction)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException();
            }
            if (age >= 18)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrimary(int a)
        {
            if (a == 1)
            {
                return false;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int poweredNumber = a;
            for (int i = 1; i < b; i++)
            {
                poweredNumber = poweredNumber * a;
            }
            return poweredNumber;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> sortedList = new List<int>();
            
            return sortedList;
        }
    }
}
