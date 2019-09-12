using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var ma3C = new Book("Grade Book Klass NA19");
            ma3C.AddGrade(89.1);
            ma3C.AddGrade(90.5);
            ma3C.AddGrade(77.3);

            //Act
            var result = ma3C.GetStatistics();

            //Assert
            Assert.Equal(85.6, result.GetAverage(), 1);

        }
    }
}
