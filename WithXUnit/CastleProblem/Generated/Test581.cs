using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test581
    {
        private readonly Mock<IClass581> aClass;

        public Test581()
        {
            this.aClass = new Mock<IClass581>();
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
