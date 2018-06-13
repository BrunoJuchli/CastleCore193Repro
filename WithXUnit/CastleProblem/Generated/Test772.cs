using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test772
    {
        private readonly Mock<IClass772> aClass;

        public Test772()
        {
            this.aClass = new Mock<IClass772>();
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
