using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test120
    {
        private readonly Mock<IClass120> aClass;

        public Test120()
        {
            this.aClass = new Mock<IClass120>();
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
