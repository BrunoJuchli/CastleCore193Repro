using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test623
    {
        private readonly Mock<IClass623> aClass;

        public Test623()
        {
            this.aClass = new Mock<IClass623>();
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
