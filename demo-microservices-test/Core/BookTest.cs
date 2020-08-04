using System;
using Xunit;

using demo_microservices_netcore.Core;

namespace demo_microservices_test.Core
{
    public class BookTest
    {
        [Fact]
        public void ShouldListBooks()
        {
            var book = new Book();
            var books = book.GetAllBooks();
            Assert.NotNull(books);       
        }
    }
}
