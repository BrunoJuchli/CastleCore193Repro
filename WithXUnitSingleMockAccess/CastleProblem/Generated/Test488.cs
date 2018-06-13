using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test488
    {
        private readonly Mock<IClass488> aClass;

        public Test488()
        {
            this.aClass = new Mock<IClass488>();
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
