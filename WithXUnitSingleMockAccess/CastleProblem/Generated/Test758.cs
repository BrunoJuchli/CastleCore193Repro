using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test758
    {
        private readonly Mock<IClass758> aClass;

        public Test758()
        {
            this.aClass = new Mock<IClass758>();
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
