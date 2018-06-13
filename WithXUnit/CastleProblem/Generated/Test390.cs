using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test390
    {
        private readonly Mock<IClass390> aClass;

        public Test390()
        {
            this.aClass = new Mock<IClass390>();
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
