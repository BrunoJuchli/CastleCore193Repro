using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test648
    {
        private readonly Mock<IClass648> aClass;

        public Test648()
        {
            this.aClass = new Mock<IClass648>();
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
