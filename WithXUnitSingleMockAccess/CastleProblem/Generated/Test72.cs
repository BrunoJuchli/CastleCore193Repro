using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test72
    {
        private readonly Mock<IClass72> aClass;

        public Test72()
        {
            this.aClass = new Mock<IClass72>();
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
