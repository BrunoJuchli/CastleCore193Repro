using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test596
    {
        private readonly Mock<IClass596> aClass;

        public Test596()
        {
            this.aClass = new Mock<IClass596>();
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
