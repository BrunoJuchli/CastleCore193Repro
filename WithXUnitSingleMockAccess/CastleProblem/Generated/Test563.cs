using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test563
    {
        private readonly Mock<IClass563> aClass;

        public Test563()
        {
            this.aClass = new Mock<IClass563>();
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
