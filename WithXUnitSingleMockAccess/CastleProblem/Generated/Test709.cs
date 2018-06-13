using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test709
    {
        private readonly Mock<IClass709> aClass;

        public Test709()
        {
            this.aClass = new Mock<IClass709>();
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
