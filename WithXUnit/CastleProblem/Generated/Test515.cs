using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test515
    {
        private readonly Mock<IClass515> aClass;

        public Test515()
        {
            this.aClass = new Mock<IClass515>();
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
