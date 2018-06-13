using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test602
    {
        private readonly Mock<IClass602> aClass;

        public Test602()
        {
            this.aClass = new Mock<IClass602>();
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
