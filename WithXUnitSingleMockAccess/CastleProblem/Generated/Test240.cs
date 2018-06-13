using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test240
    {
        private readonly Mock<IClass240> aClass;

        public Test240()
        {
            this.aClass = new Mock<IClass240>();
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
