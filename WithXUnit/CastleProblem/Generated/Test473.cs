using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test473
    {
        private readonly Mock<IClass473> aClass;

        public Test473()
        {
            this.aClass = new Mock<IClass473>();
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
