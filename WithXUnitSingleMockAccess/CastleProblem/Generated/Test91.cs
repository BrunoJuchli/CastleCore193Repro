using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test91
    {
        private readonly Mock<IClass91> aClass;

        public Test91()
        {
            this.aClass = new Mock<IClass91>();
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
