using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test474
    {
        private readonly Mock<IClass474> aClass;

        public Test474()
        {
            this.aClass = new Mock<IClass474>();
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
