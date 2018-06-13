using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test607
    {
        private readonly Mock<IClass607> aClass;

        public Test607()
        {
            this.aClass = new Mock<IClass607>();
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
