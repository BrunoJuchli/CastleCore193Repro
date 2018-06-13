using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test34
    {
        private readonly Mock<IClass34> aClass;

        public Test34()
        {
            this.aClass = new Mock<IClass34>();
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
