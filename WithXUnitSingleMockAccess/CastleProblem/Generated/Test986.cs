using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test986
    {
        private readonly Mock<IClass986> aClass;

        public Test986()
        {
            this.aClass = new Mock<IClass986>();
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
