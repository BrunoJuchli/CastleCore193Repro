using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test342
    {
        private readonly Mock<IClass342> aClass;

        public Test342()
        {
            this.aClass = new Mock<IClass342>();
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
