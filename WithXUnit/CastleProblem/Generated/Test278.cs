using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test278
    {
        private readonly Mock<IClass278> aClass;

        public Test278()
        {
            this.aClass = new Mock<IClass278>();
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
