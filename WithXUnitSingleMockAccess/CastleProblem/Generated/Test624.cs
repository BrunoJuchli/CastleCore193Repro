using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test624
    {
        private readonly Mock<IClass624> aClass;

        public Test624()
        {
            this.aClass = new Mock<IClass624>();
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
