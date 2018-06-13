using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test365
    {
        private readonly Mock<IClass365> aClass;

        public Test365()
        {
            this.aClass = new Mock<IClass365>();
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
