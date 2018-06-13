using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test429
    {
        private readonly Mock<IClass429> aClass;

        public Test429()
        {
            this.aClass = new Mock<IClass429>();
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
