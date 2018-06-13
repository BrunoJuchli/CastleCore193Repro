using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test259
    {
        private readonly Mock<IClass259> aClass;

        public Test259()
        {
            this.aClass = new Mock<IClass259>();
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
