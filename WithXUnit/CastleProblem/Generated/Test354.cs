using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test354
    {
        private readonly Mock<IClass354> aClass;

        public Test354()
        {
            this.aClass = new Mock<IClass354>();
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
