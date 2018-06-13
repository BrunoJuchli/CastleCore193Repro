using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test494
    {
        private readonly Mock<IClass494> aClass;

        public Test494()
        {
            this.aClass = new Mock<IClass494>();
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
