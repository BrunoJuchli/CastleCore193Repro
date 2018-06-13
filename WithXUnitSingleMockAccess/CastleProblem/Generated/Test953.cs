using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test953
    {
        private readonly Mock<IClass953> aClass;

        public Test953()
        {
            this.aClass = new Mock<IClass953>();
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
