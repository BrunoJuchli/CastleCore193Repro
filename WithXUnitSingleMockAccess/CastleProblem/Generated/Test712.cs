using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test712
    {
        private readonly Mock<IClass712> aClass;

        public Test712()
        {
            this.aClass = new Mock<IClass712>();
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
