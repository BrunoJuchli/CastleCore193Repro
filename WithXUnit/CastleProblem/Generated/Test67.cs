using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test67
    {
        private readonly Mock<IClass67> aClass;

        public Test67()
        {
            this.aClass = new Mock<IClass67>();
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
