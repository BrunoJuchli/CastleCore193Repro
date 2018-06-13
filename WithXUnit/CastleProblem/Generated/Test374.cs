using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test374
    {
        private readonly Mock<IClass374> aClass;

        public Test374()
        {
            this.aClass = new Mock<IClass374>();
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
