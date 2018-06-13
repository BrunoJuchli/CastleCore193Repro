using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test852
    {
        private readonly Mock<IClass852> aClass;

        public Test852()
        {
            this.aClass = new Mock<IClass852>();
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
