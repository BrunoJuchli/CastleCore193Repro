using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test543
    {
        private readonly Mock<IClass543> aClass;

        public Test543()
        {
            this.aClass = new Mock<IClass543>();
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
