using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test897
    {
        private readonly Mock<IClass897> aClass;

        public Test897()
        {
            this.aClass = new Mock<IClass897>();
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
