using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test925
    {
        private readonly Mock<IClass925> aClass;

        public Test925()
        {
            this.aClass = new Mock<IClass925>();
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
