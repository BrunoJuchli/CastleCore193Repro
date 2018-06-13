using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test195
    {
        private readonly Mock<IClass195> aClass;

        public Test195()
        {
            this.aClass = new Mock<IClass195>();
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
