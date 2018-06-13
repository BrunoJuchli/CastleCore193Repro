using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test752
    {
        private readonly Mock<IClass752> aClass;

        public Test752()
        {
            this.aClass = new Mock<IClass752>();
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
