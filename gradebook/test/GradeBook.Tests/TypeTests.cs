using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test2()
        {
            //Arrange
            var book1 = CreateNewBook("t");
            var book2 = CreateNewBook("Book 2");
            var booktest = new Book("t");

            //Act

            //Assert
            var n = book1.Name;
        }

        private static Book CreateNewBook(string name)
        {
            return new Book(name);
        }
    }
}
