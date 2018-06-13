using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test627
    {
        private readonly Mock<IClass627> aClass;

        public Test627()
        {
            this.aClass = new Mock<IClass627>();
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
