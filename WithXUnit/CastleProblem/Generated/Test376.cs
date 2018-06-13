using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test376
    {
        private readonly Mock<IClass376> aClass;

        public Test376()
        {
            this.aClass = new Mock<IClass376>();
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
