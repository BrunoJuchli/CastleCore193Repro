using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test578
    {
        private readonly Mock<IClass578> aClass;

        public Test578()
        {
            this.aClass = new Mock<IClass578>();
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
