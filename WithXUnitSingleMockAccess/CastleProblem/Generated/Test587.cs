using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test587
    {
        private readonly Mock<IClass587> aClass;

        public Test587()
        {
            this.aClass = new Mock<IClass587>();
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
