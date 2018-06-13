using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test78
    {
        private readonly Mock<IClass78> aClass;

        public Test78()
        {
            this.aClass = new Mock<IClass78>();
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
