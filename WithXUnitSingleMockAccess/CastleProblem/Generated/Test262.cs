using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test262
    {
        private readonly Mock<IClass262> aClass;

        public Test262()
        {
            this.aClass = new Mock<IClass262>();
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
