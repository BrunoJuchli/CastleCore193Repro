using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test364
    {
        private readonly Mock<IClass364> aClass;

        public Test364()
        {
            this.aClass = new Mock<IClass364>();
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
