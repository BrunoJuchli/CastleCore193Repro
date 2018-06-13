using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test162
    {
        private readonly Mock<IClass162> aClass;

        public Test162()
        {
            this.aClass = new Mock<IClass162>();
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
