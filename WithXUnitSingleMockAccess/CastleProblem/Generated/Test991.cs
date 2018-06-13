using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test991
    {
        private readonly Mock<IClass991> aClass;

        public Test991()
        {
            this.aClass = new Mock<IClass991>();
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
