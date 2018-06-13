using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test304
    {
        private readonly Mock<IClass304> aClass;

        public Test304()
        {
            this.aClass = new Mock<IClass304>();
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
