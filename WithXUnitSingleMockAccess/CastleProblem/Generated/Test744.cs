using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test744
    {
        private readonly Mock<IClass744> aClass;

        public Test744()
        {
            this.aClass = new Mock<IClass744>();
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
