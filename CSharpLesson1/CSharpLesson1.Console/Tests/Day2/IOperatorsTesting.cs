using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp.Tests.Day2
{
    public interface IOperatorsTesting
    {
        int GetSum(int a, int b);

        int GetDifference(int a, int b);

        int GetProduct(int a, int b);

        int GetQuotient(int a, int b);

        int GetRemainder(int a, int b);

        int GetPower(int a, int b);

        bool GetGreaterThan(int a, int b);

        bool GetLessThan(int a, int b);

        bool GetLessThanEqualTo(int a, int b);

        bool GetEqualTo(int a, int b);

        bool GetNotEqualTo(int a, int b);

        bool GetTrueAndTrue(bool a, bool b);

        bool GetTrueAndFalse(bool a, bool b);

        bool GetFalseAndFalse(bool a, bool b);

        bool GetTrueOrTrue(bool a, bool b);

        bool GetFalseOrFalse(bool a, bool b);

        bool GetComplexLogicalResult1(bool a, bool b, bool c, bool d);

        string GetComplexLogicalResult2(bool a, string b, string c);

        string GetComplexLogicalResult3(int a, int b, string c, string d, string e);

        string GetConcatenated(string a, string b);
    }
}
