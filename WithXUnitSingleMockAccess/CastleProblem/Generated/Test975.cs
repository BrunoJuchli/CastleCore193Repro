using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test975
    {
        private readonly Mock<IClass975> aClass;

        public Test975()
        {
            this.aClass = new Mock<IClass975>();
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
