using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test747
    {
        private readonly Mock<IClass747> aClass;

        public Test747()
        {
            this.aClass = new Mock<IClass747>();
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
