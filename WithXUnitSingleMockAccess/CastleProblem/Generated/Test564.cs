using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test564
    {
        private readonly Mock<IClass564> aClass;

        public Test564()
        {
            this.aClass = new Mock<IClass564>();
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
