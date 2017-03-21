using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp.Tests.Day2
{
    public static class TestManager
    {
        public static void RunTests<T>(T operatorsTesting) where T : IOperatorsTesting
        {
            var testResults = new List<bool>()
            {
                //int GetSum(int a, int b);
                RunTest("GetSum", operatorsTesting.GetSum(4, 4), 8),

                //int GetDifference(int a, int b);
                RunTest("GetDifference", operatorsTesting.GetDifference(100, 1000), -1900),

                //int GetProduct(int a, int b);
                RunTest("GetProduct", operatorsTesting.GetProduct(5, 8), 40),

                //int GetQuotient(int a, int b);
                RunTest("GetQuotient", operatorsTesting.GetQuotient(11, 3), 3),

                //int GetRemainder(int a, int b);
                RunTest("GetRemainder", operatorsTesting.GetRemainder(11, 3), 2),

                //int GetPower(int a, int b);
                RunTest("GetPower", operatorsTesting.GetPower(3, 8), 6561),

                //bool GetGreaterThan(int a, int b);
                RunTest("GetGreaterThan - 1", operatorsTesting.GetGreaterThan(999, 998), true),
                RunTest("GetGreaterThan - 2", operatorsTesting.GetGreaterThan(999, 999), false),
                RunTest("GetGreaterThan - 3", operatorsTesting.GetGreaterThan(998, 999), false),

                //bool GetLessThan(int a, int b);
                RunTest("GetLessThan - 1", operatorsTesting.GetLessThan(999, 998), false),
                RunTest("GetLessThan - 2", operatorsTesting.GetLessThan(999, 999), false),
                RunTest("GetLessThan - 3", operatorsTesting.GetLessThan(998, 999), true),

                //bool GetLessThanEqualTo(int a, int b);
                RunTest("GetLessThanEqualTo - 1", operatorsTesting.GetLessThanEqualTo(999, 998), false),
                RunTest("GetLessThanEqualTo - 2", operatorsTesting.GetLessThanEqualTo(999, 999), true),
                RunTest("GetLessThanEqualTo - 3", operatorsTesting.GetLessThanEqualTo(998, 999), true),

                //bool GetEqualTo(int a, int b);
                RunTest("GetEqualTo - 1", operatorsTesting.GetEqualTo(999, 998), false),
                RunTest("GetEqualTo - 2", operatorsTesting.GetEqualTo(999, 999), true),
                RunTest("GetEqualTo - 3", operatorsTesting.GetEqualTo(998, 999), false),

                //bool GetNotEqualTo(int a, int b);
                RunTest("GetNotEqualTo - 1", operatorsTesting.GetNotEqualTo(999, 998), true),
                RunTest("GetNotEqualTo - 2", operatorsTesting.GetNotEqualTo(999, 999), false),
                RunTest("GetNotEqualTo - 3", operatorsTesting.GetNotEqualTo(998, 999), true),

                //bool GetTrueAndTrue(bool a, bool b);
                RunTest("GetTrueAndTrue - 1", operatorsTesting.GetTrueAndTrue(true, true), true),
                RunTest("GetTrueAndTrue - 2", operatorsTesting.GetTrueAndTrue(true, false), false),
                RunTest("GetTrueAndTrue - 3", operatorsTesting.GetTrueAndTrue(false, false), false),
                RunTest("GetTrueAndTrue - 4", operatorsTesting.GetTrueAndTrue(false, true), false),

                //bool GetTrueAndFalse(bool a, bool b);
                RunTest("GetTrueAndFalse - 1", operatorsTesting.GetTrueAndFalse(true, true), false),
                RunTest("GetTrueAndFalse - 2", operatorsTesting.GetTrueAndFalse(true, false), true),
                RunTest("GetTrueAndFalse - 3", operatorsTesting.GetTrueAndFalse(false, false), false),
                RunTest("GetTrueAndFalse - 4", operatorsTesting.GetTrueAndFalse(false, true), false),

                //bool GetFalseAndFalse(bool a, bool b);
                RunTest("GetFalseAndFalse - 1", operatorsTesting.GetFalseAndFalse(true, true), false),
                RunTest("GetFalseAndFalse - 2", operatorsTesting.GetFalseAndFalse(true, false), false),
                RunTest("GetFalseAndFalse - 3", operatorsTesting.GetFalseAndFalse(false, false), true),
                RunTest("GetFalseAndFalse - 4", operatorsTesting.GetFalseAndFalse(false, true), false),

                //bool GetTrueOrTrue(bool a, bool b);
                RunTest("GetTrueOrTrue - 1", operatorsTesting.GetTrueOrTrue(true, true), true),
                RunTest("GetTrueOrTrue - 2", operatorsTesting.GetTrueOrTrue(true, false), true),
                RunTest("GetTrueOrTrue - 3", operatorsTesting.GetTrueOrTrue(false, false), false),
                RunTest("GetTrueOrTrue - 4", operatorsTesting.GetTrueOrTrue(false, true), true),

                //bool GetFalseOrFalse(bool a, bool b);
                RunTest("GetFalseOrFalse - 1", operatorsTesting.GetFalseOrFalse(true, true), false),
                RunTest("GetFalseOrFalse - 2", operatorsTesting.GetFalseOrFalse(true, false), true),
                RunTest("GetFalseOrFalse - 3", operatorsTesting.GetFalseOrFalse(false, false), true),
                RunTest("GetFalseOrFalse - 4", operatorsTesting.GetFalseOrFalse(false, true), true),

                //bool GetComplexLogicalResult1(bool a, bool b, bool c, bool d);
                RunTest("GetComplexLogicalResult1 - 1", operatorsTesting.GetComplexLogicalResult1(true, true, true, true), true),
                RunTest("GetComplexLogicalResult1 - 2", operatorsTesting.GetComplexLogicalResult1(true, true, true, false), false),
                RunTest("GetComplexLogicalResult1 - 3", operatorsTesting.GetComplexLogicalResult1(true, true, false, false), true),
                RunTest("GetComplexLogicalResult1 - 4", operatorsTesting.GetComplexLogicalResult1(true, false, false, false), true),
                RunTest("GetComplexLogicalResult1 - 5", operatorsTesting.GetComplexLogicalResult1(false, false, false, false), false),
                RunTest("GetComplexLogicalResult1 - 6", operatorsTesting.GetComplexLogicalResult1(true, true, false, true), true),
                RunTest("GetComplexLogicalResult1 - 7", operatorsTesting.GetComplexLogicalResult1(true, false, true, true), true),
                RunTest("GetComplexLogicalResult1 - 8", operatorsTesting.GetComplexLogicalResult1(false, true, true, true), true),
                RunTest("GetComplexLogicalResult1 - 9", operatorsTesting.GetComplexLogicalResult1(true, false, true, false), false),
                RunTest("GetComplexLogicalResult1 - 10", operatorsTesting.GetComplexLogicalResult1(false, true, false, true), true),
                RunTest("GetComplexLogicalResult1 - 11", operatorsTesting.GetComplexLogicalResult1(false, true, true, false), false),
                RunTest("GetComplexLogicalResult1 - 12", operatorsTesting.GetComplexLogicalResult1(true, false, false, true), true),
                RunTest("GetComplexLogicalResult1 - 13", operatorsTesting.GetComplexLogicalResult1(false, false, true, true), true),
                RunTest("GetComplexLogicalResult1 - 14", operatorsTesting.GetComplexLogicalResult1(false, false, false, true), true),
                RunTest("GetComplexLogicalResult1 - 15", operatorsTesting.GetComplexLogicalResult1(false, true, false, false), true),
                RunTest("GetComplexLogicalResult1 - 16", operatorsTesting.GetComplexLogicalResult1(false, false, true, false), false),

                //string GetComplexLogicalResult2(bool a, string b, string c);
                RunTest("GetComplexLogicalResult2 - 1", operatorsTesting.GetComplexLogicalResult2(true, "foo", "bar"), "foo"),
                RunTest("GetComplexLogicalResult2 - 2", operatorsTesting.GetComplexLogicalResult2(false, "foo", "bar"), "bar"),

                //string GetComplexLogicalResult3(bool a, bool b, string c, string d, string e);
                RunTest("GetComplexLogicalResult3 - 1", operatorsTesting.GetComplexLogicalResult3(true, true, "foo", "bar", "baz"), "foo"),
                RunTest("GetComplexLogicalResult3 - 2", operatorsTesting.GetComplexLogicalResult3(true, false, "foo", "bar", "baz"), "foo"),
                RunTest("GetComplexLogicalResult3 - 3", operatorsTesting.GetComplexLogicalResult3(false, true, "foo", "bar", "baz"), "bar"),
                RunTest("GetComplexLogicalResult3 - 4", operatorsTesting.GetComplexLogicalResult3(false, false, "foo", "bar", "baz"), "baz"),

                //string GetConcatenated(string a, string b);
                RunTest("GetConcatenated", operatorsTesting.GetConcatenated("hello", "World!"), "hello World!")
            };

            var passed = testResults
                .Count(testPassed => testPassed);
            var failed = testResults.Count - passed;

            Console.WriteLine($"\n\nTEST COMPLETED: {passed + failed} RUN, {passed} PASSED, {failed} FAILED");
        }

        public static bool RunTest<TResult>(string testName, TResult actual, TResult expected)
        {
            if (actual.Equals(expected))
            {
                Console.WriteLine($"PASS:  {testName}");
                return true;
            }

            Console.WriteLine($"FAIL:  {testName} (Actual: {actual}, Expected: {expected})");
            return false;
        }
    }
}
