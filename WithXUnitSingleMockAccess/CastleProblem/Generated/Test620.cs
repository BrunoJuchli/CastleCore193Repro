using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test620
    {
        private readonly Mock<IClass620> aClass;

        public Test620()
        {
            this.aClass = new Mock<IClass620>();
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
