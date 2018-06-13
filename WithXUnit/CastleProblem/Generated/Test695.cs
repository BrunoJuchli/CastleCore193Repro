using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test695
    {
        private readonly Mock<IClass695> aClass;

        public Test695()
        {
            this.aClass = new Mock<IClass695>();
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
