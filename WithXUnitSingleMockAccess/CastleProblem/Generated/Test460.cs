using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test460
    {
        private readonly Mock<IClass460> aClass;

        public Test460()
        {
            this.aClass = new Mock<IClass460>();
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
