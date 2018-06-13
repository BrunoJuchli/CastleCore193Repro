using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test951
    {
        private readonly Mock<IClass951> aClass;

        public Test951()
        {
            this.aClass = new Mock<IClass951>();
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
