using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test131
    {
        private readonly Mock<IClass131> aClass;

        public Test131()
        {
            this.aClass = new Mock<IClass131>();
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
