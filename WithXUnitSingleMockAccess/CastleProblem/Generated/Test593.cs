using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test593
    {
        private readonly Mock<IClass593> aClass;

        public Test593()
        {
            this.aClass = new Mock<IClass593>();
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
