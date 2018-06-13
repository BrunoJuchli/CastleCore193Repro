using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test12
    {
        private readonly Mock<IClass12> aClass;

        public Test12()
        {
            this.aClass = new Mock<IClass12>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
