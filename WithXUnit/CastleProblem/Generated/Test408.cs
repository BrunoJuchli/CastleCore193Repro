using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test408
    {
        private readonly Mock<IClass408> aClass;

        public Test408()
        {
            this.aClass = new Mock<IClass408>();
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
