using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test749
    {
        private readonly Mock<IClass749> aClass;

        public Test749()
        {
            this.aClass = new Mock<IClass749>();
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
