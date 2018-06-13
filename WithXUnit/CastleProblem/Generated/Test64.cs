using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test64
    {
        private readonly Mock<IClass64> aClass;

        public Test64()
        {
            this.aClass = new Mock<IClass64>();
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
