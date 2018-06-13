using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test822
    {
        private readonly Mock<IClass822> aClass;

        public Test822()
        {
            this.aClass = new Mock<IClass822>();
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
