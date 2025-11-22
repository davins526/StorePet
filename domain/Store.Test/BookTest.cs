using Xunit;
using System;
using Store.Memory;

namespace Store.Test
{
    public class BookTest
    {
       
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);


            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithIsbn10_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");


            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");


            Assert.True(actual);
        }
    }
}
