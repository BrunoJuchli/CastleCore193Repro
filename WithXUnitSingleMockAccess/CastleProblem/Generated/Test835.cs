using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test835
    {
        private readonly Mock<IClass835> aClass;

        public Test835()
        {
            this.aClass = new Mock<IClass835>();
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
