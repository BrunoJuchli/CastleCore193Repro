using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test48
    {
        private readonly Mock<IClass48> aClass;

        public Test48()
        {
            this.aClass = new Mock<IClass48>();
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
