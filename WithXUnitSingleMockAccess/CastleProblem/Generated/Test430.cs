using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test430
    {
        private readonly Mock<IClass430> aClass;

        public Test430()
        {
            this.aClass = new Mock<IClass430>();
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
