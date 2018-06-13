using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test692
    {
        private readonly Mock<IClass692> aClass;

        public Test692()
        {
            this.aClass = new Mock<IClass692>();
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
