using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test27
    {
        private readonly Mock<IClass27> aClass;

        public Test27()
        {
            this.aClass = new Mock<IClass27>();
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
