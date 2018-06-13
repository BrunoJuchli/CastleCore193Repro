using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test866
    {
        private readonly Mock<IClass866> aClass;

        public Test866()
        {
            this.aClass = new Mock<IClass866>();
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
