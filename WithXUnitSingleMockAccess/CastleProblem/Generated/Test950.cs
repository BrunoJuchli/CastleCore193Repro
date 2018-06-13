using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test950
    {
        private readonly Mock<IClass950> aClass;

        public Test950()
        {
            this.aClass = new Mock<IClass950>();
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
