using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test55
    {
        private readonly Mock<IClass55> aClass;

        public Test55()
        {
            this.aClass = new Mock<IClass55>();
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
