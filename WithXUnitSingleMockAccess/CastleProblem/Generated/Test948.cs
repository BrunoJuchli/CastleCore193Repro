using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test948
    {
        private readonly Mock<IClass948> aClass;

        public Test948()
        {
            this.aClass = new Mock<IClass948>();
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
