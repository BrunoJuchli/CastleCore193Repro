using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test202
    {
        private readonly Mock<IClass202> aClass;

        public Test202()
        {
            this.aClass = new Mock<IClass202>();
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
