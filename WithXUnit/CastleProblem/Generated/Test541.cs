using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test541
    {
        private readonly Mock<IClass541> aClass;

        public Test541()
        {
            this.aClass = new Mock<IClass541>();
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
