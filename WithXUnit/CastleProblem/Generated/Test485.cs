using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test485
    {
        private readonly Mock<IClass485> aClass;

        public Test485()
        {
            this.aClass = new Mock<IClass485>();
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
