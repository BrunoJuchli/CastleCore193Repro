using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test820
    {
        private readonly Mock<IClass820> aClass;

        public Test820()
        {
            this.aClass = new Mock<IClass820>();
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
