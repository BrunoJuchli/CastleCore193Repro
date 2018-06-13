using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test805
    {
        private readonly Mock<IClass805> aClass;

        public Test805()
        {
            this.aClass = new Mock<IClass805>();
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
