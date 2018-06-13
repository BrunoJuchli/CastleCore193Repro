using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test789
    {
        private readonly Mock<IClass789> aClass;

        public Test789()
        {
            this.aClass = new Mock<IClass789>();
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
