using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Bka()
        {
            var dddd = 4;
            Console.WriteLine(dddd);
            Assert.True(dddd == 2);

        }
    }
}
