using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test269
    {
        private readonly Mock<IClass269> aClass;

        public Test269()
        {
            this.aClass = new Mock<IClass269>();
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
