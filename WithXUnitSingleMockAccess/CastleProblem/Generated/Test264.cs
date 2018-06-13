using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test264
    {
        private readonly Mock<IClass264> aClass;

        public Test264()
        {
            this.aClass = new Mock<IClass264>();
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
