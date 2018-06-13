using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test433
    {
        private readonly Mock<IClass433> aClass;

        public Test433()
        {
            this.aClass = new Mock<IClass433>();
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
