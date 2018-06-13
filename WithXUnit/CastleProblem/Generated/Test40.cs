using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test40
    {
        private readonly Mock<IClass40> aClass;

        public Test40()
        {
            this.aClass = new Mock<IClass40>();
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
