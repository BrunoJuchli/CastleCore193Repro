using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test128
    {
        private readonly Mock<IClass128> aClass;

        public Test128()
        {
            this.aClass = new Mock<IClass128>();
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
