using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test487
    {
        private readonly Mock<IClass487> aClass;

        public Test487()
        {
            this.aClass = new Mock<IClass487>();
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
