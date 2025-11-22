using Xunit;
using System;
using Store.Memory;

namespace Store.Test
{
    public class UnitTest1
    {
        

        public BookService(IBookService bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [Fact]
        public void Test1()
        {
            
        }
    }
}
