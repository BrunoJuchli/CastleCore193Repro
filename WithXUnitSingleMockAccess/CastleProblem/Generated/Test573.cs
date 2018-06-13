using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test573
    {
        private readonly Mock<IClass573> aClass;

        public Test573()
        {
            this.aClass = new Mock<IClass573>();
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
