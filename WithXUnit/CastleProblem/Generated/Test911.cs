using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test911
    {
        private readonly Mock<IClass911> aClass;

        public Test911()
        {
            this.aClass = new Mock<IClass911>();
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
