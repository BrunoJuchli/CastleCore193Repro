using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test802
    {
        private readonly Mock<IClass802> aClass;

        public Test802()
        {
            this.aClass = new Mock<IClass802>();
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
