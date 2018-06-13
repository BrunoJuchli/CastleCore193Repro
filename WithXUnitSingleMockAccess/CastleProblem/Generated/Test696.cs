using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test696
    {
        private readonly Mock<IClass696> aClass;

        public Test696()
        {
            this.aClass = new Mock<IClass696>();
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
