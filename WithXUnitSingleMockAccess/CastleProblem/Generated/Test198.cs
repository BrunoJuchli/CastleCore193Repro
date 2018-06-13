using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test198
    {
        private readonly Mock<IClass198> aClass;

        public Test198()
        {
            this.aClass = new Mock<IClass198>();
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
