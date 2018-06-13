using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test83
    {
        private readonly Mock<IClass83> aClass;

        public Test83()
        {
            this.aClass = new Mock<IClass83>();
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
