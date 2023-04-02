using HackerRank.Prepare.ProblemSolving;
using System;

namespace HackerRank_Tests
{
    public class ProblemSolvingTests
    {
        public static IEnumerable<object[]> MiniMaxSum_TestData =>
            new List<object[]>
            {
            new object[] { new List<int> { 1, 2, 3, 4, 5 }, "10 14" },
            new object[] { new List<int> { 1, 2, 3, 4, 7 }, "10 16" },
            new object[] { new List<int> { 1, 1, 1, 1, 1 }, "4 4" },
            new object[] { new List<int> { 7, 69, 2, 221, 8974 }, "299 9271" }
            };

        public static IEnumerable<object[]> GradingStudents_TestData =>
           new List<object[]>
           {
            new object[] { new List<int> { 4, 73,67,38,33 }, new List<int>{ 75,67,40,33 }},
            new object[] {
                new List<int> {50, 59, 36, 97, 28, 61, 54, 27, 14, 29, 81, 16, 7, 1, 99, 42, 77, 39, 20, 29, 0, 1, 82, 20, 71, 71, 73, 79, 77, 61, 7, 93, 36, 65, 11, 92, 87, 85, 62, 45, 33, 9, 6, 37, 31, 67, 32, 67, 73, 59, 95 },
                new List<int> { 60, 36, 97, 28, 61, 55, 27, 14, 29, 81, 16, 7, 1, 100, 42, 77, 40, 20, 29, 0, 1, 82, 20, 71, 71, 75, 80, 77, 61, 7, 95, 36, 65, 11, 92, 87, 85, 62, 45, 33, 9, 6, 37, 31, 67, 32, 67, 75, 60, 95 } },
           };

        [Theory]
        [MemberData(nameof(GradingStudents_TestData))]
        public void GradingStudents(List<int> input, List<int> expected)
        {
            var response = Excersices.GradingStudents(input);
            Assert.Equal(response, expected);
        }

        [Theory]
        [MemberData(nameof(MiniMaxSum_TestData))]
        public void MiniMaxSum(List<int> arr, string expectedOutput)
        {
            string actualOutput = Excersices.MiniMaxSum(arr);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [MemberData(nameof(CountApplesAndOranges_TestData))]
        public void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges, string expected)
        {
            var response = Excersices.CountApplesAndOranges(s, t, a, b, apples, oranges);
            response.Should().Be(expected);
        }

        public static IEnumerable<object[]> CountApplesAndOranges_TestData =>
           new List<object[]>
           {
            new object[] {7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 } , "1 1" },
            new object[] {7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3,-2,-4 } , "1 2" },
           };

        [Theory]
        [MemberData(nameof(JumpingKangaroos_TestData))]
        public void JumpingKangaroos(int x1, int v1, int x2, int v2, string expected)
        {
            var response = Excersices.JumpingKangaroos(x1, v1, x2, v2);
            response.Should().Be(expected);
        }

        public static IEnumerable<object[]> JumpingKangaroos_TestData =>
           new List<object[]>
           {
            new object[] {0, 3, 4, 2  , "YES" },
            new object[] {0, 2, 5, 3,  "NO" },
            new object[] { 1113, 612, 1331, 610,  "YES" },
           };
    }
}