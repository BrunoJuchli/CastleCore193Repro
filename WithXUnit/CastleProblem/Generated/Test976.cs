using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test976
    {
        private readonly Mock<IClass976> aClass;

        public Test976()
        {
            this.aClass = new Mock<IClass976>();
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
