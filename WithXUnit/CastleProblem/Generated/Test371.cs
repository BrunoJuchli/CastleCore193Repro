using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test371
    {
        private readonly Mock<IClass371> aClass;

        public Test371()
        {
            this.aClass = new Mock<IClass371>();
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
