using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test81
    {
        private readonly Mock<IClass81> aClass;

        public Test81()
        {
            this.aClass = new Mock<IClass81>();
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
