using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test778
    {
        private readonly Mock<IClass778> aClass;

        public Test778()
        {
            this.aClass = new Mock<IClass778>();
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
