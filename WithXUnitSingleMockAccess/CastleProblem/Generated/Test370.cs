using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test370
    {
        private readonly Mock<IClass370> aClass;

        public Test370()
        {
            this.aClass = new Mock<IClass370>();
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
