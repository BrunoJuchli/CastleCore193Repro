using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test84
    {
        private readonly Mock<IClass84> aClass;

        public Test84()
        {
            this.aClass = new Mock<IClass84>();
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
