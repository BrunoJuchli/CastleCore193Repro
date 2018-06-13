using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test319
    {
        private readonly Mock<IClass319> aClass;

        public Test319()
        {
            this.aClass = new Mock<IClass319>();
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
