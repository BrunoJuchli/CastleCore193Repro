using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test438
    {
        private readonly Mock<IClass438> aClass;

        public Test438()
        {
            this.aClass = new Mock<IClass438>();
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
