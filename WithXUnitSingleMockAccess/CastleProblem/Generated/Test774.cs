using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test774
    {
        private readonly Mock<IClass774> aClass;

        public Test774()
        {
            this.aClass = new Mock<IClass774>();
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
