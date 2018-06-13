using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test151
    {
        private readonly Mock<IClass151> aClass;

        public Test151()
        {
            this.aClass = new Mock<IClass151>();
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
