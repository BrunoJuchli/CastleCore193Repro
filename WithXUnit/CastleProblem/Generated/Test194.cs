using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test194
    {
        private readonly Mock<IClass194> aClass;

        public Test194()
        {
            this.aClass = new Mock<IClass194>();
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
