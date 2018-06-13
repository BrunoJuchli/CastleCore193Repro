using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test328
    {
        private readonly Mock<IClass328> aClass;

        public Test328()
        {
            this.aClass = new Mock<IClass328>();
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
