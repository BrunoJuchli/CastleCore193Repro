using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test780
    {
        private readonly Mock<IClass780> aClass;

        public Test780()
        {
            this.aClass = new Mock<IClass780>();
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
