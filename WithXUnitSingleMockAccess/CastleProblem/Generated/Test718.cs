using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test718
    {
        private readonly Mock<IClass718> aClass;

        public Test718()
        {
            this.aClass = new Mock<IClass718>();
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
