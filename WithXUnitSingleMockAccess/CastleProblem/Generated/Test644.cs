using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test644
    {
        private readonly Mock<IClass644> aClass;

        public Test644()
        {
            this.aClass = new Mock<IClass644>();
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
