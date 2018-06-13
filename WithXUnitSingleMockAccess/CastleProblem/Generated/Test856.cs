using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test856
    {
        private readonly Mock<IClass856> aClass;

        public Test856()
        {
            this.aClass = new Mock<IClass856>();
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
