using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test974
    {
        private readonly Mock<IClass974> aClass;

        public Test974()
        {
            this.aClass = new Mock<IClass974>();
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
