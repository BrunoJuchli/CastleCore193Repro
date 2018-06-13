using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test642
    {
        private readonly Mock<IClass642> aClass;

        public Test642()
        {
            this.aClass = new Mock<IClass642>();
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
