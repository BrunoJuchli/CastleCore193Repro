using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test542
    {
        private readonly Mock<IClass542> aClass;

        public Test542()
        {
            this.aClass = new Mock<IClass542>();
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
