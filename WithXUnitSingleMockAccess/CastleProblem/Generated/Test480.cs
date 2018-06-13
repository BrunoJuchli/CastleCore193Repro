using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test480
    {
        private readonly Mock<IClass480> aClass;

        public Test480()
        {
            this.aClass = new Mock<IClass480>();
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
