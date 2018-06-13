using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test764
    {
        private readonly Mock<IClass764> aClass;

        public Test764()
        {
            this.aClass = new Mock<IClass764>();
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
