using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test451
    {
        private readonly Mock<IClass451> aClass;

        public Test451()
        {
            this.aClass = new Mock<IClass451>();
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
