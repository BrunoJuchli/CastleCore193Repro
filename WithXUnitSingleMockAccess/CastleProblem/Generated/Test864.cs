using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test864
    {
        private readonly Mock<IClass864> aClass;

        public Test864()
        {
            this.aClass = new Mock<IClass864>();
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
