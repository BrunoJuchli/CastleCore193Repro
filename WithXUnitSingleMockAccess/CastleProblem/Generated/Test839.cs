using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test839
    {
        private readonly Mock<IClass839> aClass;

        public Test839()
        {
            this.aClass = new Mock<IClass839>();
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
