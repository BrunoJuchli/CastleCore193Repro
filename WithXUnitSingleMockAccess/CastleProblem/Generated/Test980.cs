using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test980
    {
        private readonly Mock<IClass980> aClass;

        public Test980()
        {
            this.aClass = new Mock<IClass980>();
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
