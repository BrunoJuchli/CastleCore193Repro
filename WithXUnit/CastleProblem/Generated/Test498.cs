using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test498
    {
        private readonly Mock<IClass498> aClass;

        public Test498()
        {
            this.aClass = new Mock<IClass498>();
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
