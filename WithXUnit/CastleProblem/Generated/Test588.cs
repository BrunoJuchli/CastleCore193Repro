using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test588
    {
        private readonly Mock<IClass588> aClass;

        public Test588()
        {
            this.aClass = new Mock<IClass588>();
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
