using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test536
    {
        private readonly Mock<IClass536> aClass;

        public Test536()
        {
            this.aClass = new Mock<IClass536>();
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
