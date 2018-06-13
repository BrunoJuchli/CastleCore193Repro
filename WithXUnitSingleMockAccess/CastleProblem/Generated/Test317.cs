using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test317
    {
        private readonly Mock<IClass317> aClass;

        public Test317()
        {
            this.aClass = new Mock<IClass317>();
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
