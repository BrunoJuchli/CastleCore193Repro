using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test63
    {
        private readonly Mock<IClass63> aClass;

        public Test63()
        {
            this.aClass = new Mock<IClass63>();
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
