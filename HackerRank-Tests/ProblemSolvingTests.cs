using HackerRank.Prepare.ProblemSolving;

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
    }
}