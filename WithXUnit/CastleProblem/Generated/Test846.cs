using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test846
    {
        private readonly Mock<IClass846> aClass;

        public Test846()
        {
            this.aClass = new Mock<IClass846>();
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
