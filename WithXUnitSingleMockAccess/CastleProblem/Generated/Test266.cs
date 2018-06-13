using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test266
    {
        private readonly Mock<IClass266> aClass;

        public Test266()
        {
            this.aClass = new Mock<IClass266>();
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
