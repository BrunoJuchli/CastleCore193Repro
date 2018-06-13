using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test406
    {
        private readonly Mock<IClass406> aClass;

        public Test406()
        {
            this.aClass = new Mock<IClass406>();
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
