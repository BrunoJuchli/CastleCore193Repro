using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test395
    {
        private readonly Mock<IClass395> aClass;

        public Test395()
        {
            this.aClass = new Mock<IClass395>();
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
