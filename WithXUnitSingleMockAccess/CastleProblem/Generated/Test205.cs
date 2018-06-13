using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test205
    {
        private readonly Mock<IClass205> aClass;

        public Test205()
        {
            this.aClass = new Mock<IClass205>();
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
