using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test761
    {
        private readonly Mock<IClass761> aClass;

        public Test761()
        {
            this.aClass = new Mock<IClass761>();
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
