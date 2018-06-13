using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test614
    {
        private readonly Mock<IClass614> aClass;

        public Test614()
        {
            this.aClass = new Mock<IClass614>();
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
