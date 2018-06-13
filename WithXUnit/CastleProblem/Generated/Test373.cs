using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test373
    {
        private readonly Mock<IClass373> aClass;

        public Test373()
        {
            this.aClass = new Mock<IClass373>();
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
