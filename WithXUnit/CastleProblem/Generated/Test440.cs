using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test440
    {
        private readonly Mock<IClass440> aClass;

        public Test440()
        {
            this.aClass = new Mock<IClass440>();
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
