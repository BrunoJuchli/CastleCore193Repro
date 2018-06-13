using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test729
    {
        private readonly Mock<IClass729> aClass;

        public Test729()
        {
            this.aClass = new Mock<IClass729>();
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
