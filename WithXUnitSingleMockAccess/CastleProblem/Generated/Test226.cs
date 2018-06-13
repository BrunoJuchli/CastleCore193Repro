using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test226
    {
        private readonly Mock<IClass226> aClass;

        public Test226()
        {
            this.aClass = new Mock<IClass226>();
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
