using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test458
    {
        private readonly Mock<IClass458> aClass;

        public Test458()
        {
            this.aClass = new Mock<IClass458>();
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
