using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test143
    {
        private readonly Mock<IClass143> aClass;

        public Test143()
        {
            this.aClass = new Mock<IClass143>();
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
