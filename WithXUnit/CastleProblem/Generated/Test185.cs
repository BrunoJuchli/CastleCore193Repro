using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test185
    {
        private readonly Mock<IClass185> aClass;

        public Test185()
        {
            this.aClass = new Mock<IClass185>();
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
