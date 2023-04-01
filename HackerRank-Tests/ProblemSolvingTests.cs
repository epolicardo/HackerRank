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
            new object[] { new List<int> { 1, 2, 3, 4, 5 }, "10 14" },
            new object[] { new List<int> { 1, 2, 3, 4, 7 }, "10 16" },
            new object[] { new List<int> { 1, 1, 1, 1, 1 }, "4 4" },
            new object[] { new List<int> { 7, 69, 2, 221, 8974 }, "299 9271" }
           };

        [Fact]
        [MemberData(nameof(GradingStudents_TestData))]
        public void GradingStudents_ShouldPass()
        {
            var gradeList = new List<int> { 84, 36 };
            var resultList = new List<int> { 75, 67, 40, 33 };
            var response = Excersices.GradingStudents(grades: gradeList);
            Assert.NotNull(response);
            response.Should().BeEquivalentTo(gradeList);
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