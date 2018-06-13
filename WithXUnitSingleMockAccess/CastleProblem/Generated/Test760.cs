using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test760
    {
        private readonly Mock<IClass760> aClass;

        public Test760()
        {
            this.aClass = new Mock<IClass760>();
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
