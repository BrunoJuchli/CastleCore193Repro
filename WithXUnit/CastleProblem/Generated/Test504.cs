using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test504
    {
        private readonly Mock<IClass504> aClass;

        public Test504()
        {
            this.aClass = new Mock<IClass504>();
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
