using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test157
    {
        private readonly Mock<IClass157> aClass;

        public Test157()
        {
            this.aClass = new Mock<IClass157>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
