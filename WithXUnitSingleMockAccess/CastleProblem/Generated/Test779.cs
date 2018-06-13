using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test779
    {
        private readonly Mock<IClass779> aClass;

        public Test779()
        {
            this.aClass = new Mock<IClass779>();
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
