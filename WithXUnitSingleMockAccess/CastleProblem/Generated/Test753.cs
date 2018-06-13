using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test753
    {
        private readonly Mock<IClass753> aClass;

        public Test753()
        {
            this.aClass = new Mock<IClass753>();
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
