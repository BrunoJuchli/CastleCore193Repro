using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test273
    {
        private readonly Mock<IClass273> aClass;

        public Test273()
        {
            this.aClass = new Mock<IClass273>();
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
