using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test309
    {
        private readonly Mock<IClass309> aClass;

        public Test309()
        {
            this.aClass = new Mock<IClass309>();
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
