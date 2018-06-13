using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test268
    {
        private readonly Mock<IClass268> aClass;

        public Test268()
        {
            this.aClass = new Mock<IClass268>();
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
