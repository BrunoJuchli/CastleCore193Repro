using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test715
    {
        private readonly Mock<IClass715> aClass;

        public Test715()
        {
            this.aClass = new Mock<IClass715>();
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
