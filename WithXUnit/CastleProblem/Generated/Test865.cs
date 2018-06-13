using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test865
    {
        private readonly Mock<IClass865> aClass;

        public Test865()
        {
            this.aClass = new Mock<IClass865>();
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
