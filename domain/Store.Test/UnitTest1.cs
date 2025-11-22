using Xunit;
using System;
using Store.Memory;

namespace Store.Test
{
    public class BookTest
    {
       
        [Fact]
        public void IsIsbn_WithNull_ReturnFlase()
        {
            bool actual = Book.IsIsbn(null);


            Assert.True(actual);
        }
    }
}
