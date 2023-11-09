using HackerRank.InterviewPreparation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Tests
{
    public class OneWeekPreparationKitTests
    {
        public static IEnumerable<object[]> MiniMaxSum_TestData =>
         new List<object[]>
         {
            new object[] {new List<int> { 1,3,5,7,9 }, new List<int> { 5, -6 } , "1 1" },
         };

        public static IEnumerable<object[]> FindMedian_TestData =>
         new List<object[]>
         {
            new object[] {new List<int> { 0,1,2,4,6,5,3 }, 3 }
         };

        [Theory]
        [MemberData(nameof(MiniMaxSum_TestData))]
        public void GradingStudents(List<int> input, List<int> expected)
        {
            var response = Excersices.GradingStudents(input);
            Assert.Equal(response, expected);
        }

        [Theory]
        [MemberData(nameof(FindMedian_TestData))]
        public void findMedian(List<int> input, int expected)
        {
            var response = OneWeekPreparationKit.findMedian(input);
            Assert.Equal(response, expected);
        }

        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("09:01:00AM", "09:01:00")]
        [InlineData("12:45:54PM", "12:45:54")]
        public void TimeConversion(string input, string expected)
        {
            var response = OneWeekPreparationKit.timeConversion(input);
            Assert.Equal(response, expected);
        }
    }
}