using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test320
    {
        private readonly Mock<IClass320> aClass;

        public Test320()
        {
            this.aClass = new Mock<IClass320>();
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
