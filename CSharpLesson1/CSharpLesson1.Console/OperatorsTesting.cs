using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp
{
    public class OperatorsTesting
    {
        public int GetSum(int a, int b)
        {
            return a + b;
        }
        public int GetDifference(int a, int b)
        {
            return a - b;
        }
        public int GetProduct(int a, int b)
        {
            return a * b;
        }
        public float GetQuotient(int a, int b)
        {
            return a / b;
        }
        public int GetRemainder(int a, int b)
        {
            return a % b;
        }
        public int GetPower(int a, int b)
        {
            return a ^ b;
        }

        public bool GetGreaterThan(int a, int b)
        {
            return a > b;
        }
        public bool GetLessThan(int a, int b)
        {
            return a < b;
        }
        public bool GetLessThanEqualTo(int a, int b)
        {
            return a <= b;
        }
        public bool GetEqualto(int a, int b)
        {
            return a == b;
        }
        public bool GetNotEqualTo(int a, int b)
        {
            return a != b;
        }
        public bool GetTrueAndTrue(bool a, bool b)
        {
            return a && b;
        }
        public bool GetTrueAndFalse(bool a, bool b)
        {
            return a && b;
        }
        public bool GetFalseAndFalse(bool a, bool b)
        {
            return a || b;
        }
        public bool GetTrueOrTrue(bool a, bool b)
        {
            return a || b;
        }
        public bool GetFalseOrFalse(bool a, bool b)
        {
            return a ^ b;
        }
        public string GetComplexLogicalResult2(bool a, string b, string c)
        {
            if (a)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public bool GetComplexLogicalResult1(bool a, bool b, bool c, bool d)
        {
            return true;
        }

        public string GetComplexLogicalResult3(bool a, bool b, string c, string d, string e)
        {
            return string.Empty;
        }

        public string GetConcatenated(string a, string b)
        {
            return string.Empty;
        }
    }
}
