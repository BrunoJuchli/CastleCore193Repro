using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test653
    {
        private readonly Mock<IClass653> aClass;

        public Test653()
        {
            this.aClass = new Mock<IClass653>();
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
