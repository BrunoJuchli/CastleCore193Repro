using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test985
    {
        private readonly Mock<IClass985> aClass;

        public Test985()
        {
            this.aClass = new Mock<IClass985>();
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
