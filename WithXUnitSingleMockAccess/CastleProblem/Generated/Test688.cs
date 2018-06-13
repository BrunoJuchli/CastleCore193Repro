using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test688
    {
        private readonly Mock<IClass688> aClass;

        public Test688()
        {
            this.aClass = new Mock<IClass688>();
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
