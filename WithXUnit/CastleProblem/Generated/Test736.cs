using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test736
    {
        private readonly Mock<IClass736> aClass;

        public Test736()
        {
            this.aClass = new Mock<IClass736>();
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
