using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _07_CustomTaskLikeTypes
{
    [TestFixture]
    public class Sample
    {
        [Test]
        public async TaskLike FooAsync()
        {
            await Task.Yield();
            await default(TaskLike);
        }

        [Test]
        public void WrapFoo()
        {
            var result = FooAsync();
            Assert.NotNull(result);
        }
    }
}
