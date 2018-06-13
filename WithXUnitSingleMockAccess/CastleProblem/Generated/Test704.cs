using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test704
    {
        private readonly Mock<IClass704> aClass;

        public Test704()
        {
            this.aClass = new Mock<IClass704>();
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
