using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test808
    {
        private readonly Mock<IClass808> aClass;

        public Test808()
        {
            this.aClass = new Mock<IClass808>();
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
