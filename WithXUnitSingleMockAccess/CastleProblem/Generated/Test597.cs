using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test597
    {
        private readonly Mock<IClass597> aClass;

        public Test597()
        {
            this.aClass = new Mock<IClass597>();
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
