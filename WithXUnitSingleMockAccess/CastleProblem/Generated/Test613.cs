using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test613
    {
        private readonly Mock<IClass613> aClass;

        public Test613()
        {
            this.aClass = new Mock<IClass613>();
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
