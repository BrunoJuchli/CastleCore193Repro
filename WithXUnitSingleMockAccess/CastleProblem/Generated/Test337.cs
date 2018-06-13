using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test337
    {
        private readonly Mock<IClass337> aClass;

        public Test337()
        {
            this.aClass = new Mock<IClass337>();
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
