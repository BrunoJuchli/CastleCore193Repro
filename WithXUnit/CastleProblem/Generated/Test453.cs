using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test453
    {
        private readonly Mock<IClass453> aClass;

        public Test453()
        {
            this.aClass = new Mock<IClass453>();
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
