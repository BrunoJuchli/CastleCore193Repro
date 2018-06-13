using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test283
    {
        private readonly Mock<IClass283> aClass;

        public Test283()
        {
            this.aClass = new Mock<IClass283>();
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
