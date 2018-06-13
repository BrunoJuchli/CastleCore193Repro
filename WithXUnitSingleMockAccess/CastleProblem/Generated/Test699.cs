using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test699
    {
        private readonly Mock<IClass699> aClass;

        public Test699()
        {
            this.aClass = new Mock<IClass699>();
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
