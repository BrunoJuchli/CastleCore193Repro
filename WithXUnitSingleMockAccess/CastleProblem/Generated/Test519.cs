using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test519
    {
        private readonly Mock<IClass519> aClass;

        public Test519()
        {
            this.aClass = new Mock<IClass519>();
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
