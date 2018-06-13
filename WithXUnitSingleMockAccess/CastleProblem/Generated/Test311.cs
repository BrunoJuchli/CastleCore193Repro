using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test311
    {
        private readonly Mock<IClass311> aClass;

        public Test311()
        {
            this.aClass = new Mock<IClass311>();
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
