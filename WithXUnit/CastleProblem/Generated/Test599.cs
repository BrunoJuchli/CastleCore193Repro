using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test599
    {
        private readonly Mock<IClass599> aClass;

        public Test599()
        {
            this.aClass = new Mock<IClass599>();
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
