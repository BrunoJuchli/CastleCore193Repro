using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test31
    {
        private readonly Mock<IClass31> aClass;

        public Test31()
        {
            this.aClass = new Mock<IClass31>();
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
