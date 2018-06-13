using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test998
    {
        private readonly Mock<IClass998> aClass;

        public Test998()
        {
            this.aClass = new Mock<IClass998>();
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
