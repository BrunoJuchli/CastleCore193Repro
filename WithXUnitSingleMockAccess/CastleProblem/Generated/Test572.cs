using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test572
    {
        private readonly Mock<IClass572> aClass;

        public Test572()
        {
            this.aClass = new Mock<IClass572>();
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
