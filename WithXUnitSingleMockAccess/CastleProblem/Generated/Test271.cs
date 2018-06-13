using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test271
    {
        private readonly Mock<IClass271> aClass;

        public Test271()
        {
            this.aClass = new Mock<IClass271>();
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
