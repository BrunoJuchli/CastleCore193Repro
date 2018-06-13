using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test89
    {
        private readonly Mock<IClass89> aClass;

        public Test89()
        {
            this.aClass = new Mock<IClass89>();
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
