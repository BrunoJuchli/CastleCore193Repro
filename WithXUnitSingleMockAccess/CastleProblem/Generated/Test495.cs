using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test495
    {
        private readonly Mock<IClass495> aClass;

        public Test495()
        {
            this.aClass = new Mock<IClass495>();
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
