using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test19
    {
        private readonly Mock<IClass19> aClass;

        public Test19()
        {
            this.aClass = new Mock<IClass19>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
