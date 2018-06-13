using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test768
    {
        private readonly Mock<IClass768> aClass;

        public Test768()
        {
            this.aClass = new Mock<IClass768>();
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
