using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test583
    {
        private readonly Mock<IClass583> aClass;

        public Test583()
        {
            this.aClass = new Mock<IClass583>();
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
