using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test570
    {
        private readonly Mock<IClass570> aClass;

        public Test570()
        {
            this.aClass = new Mock<IClass570>();
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
