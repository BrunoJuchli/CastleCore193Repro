using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test359
    {
        private readonly Mock<IClass359> aClass;

        public Test359()
        {
            this.aClass = new Mock<IClass359>();
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
