using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test674
    {
        private readonly Mock<IClass674> aClass;

        public Test674()
        {
            this.aClass = new Mock<IClass674>();
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
