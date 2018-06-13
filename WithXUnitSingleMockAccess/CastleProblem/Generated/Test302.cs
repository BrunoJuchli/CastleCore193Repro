using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test302
    {
        private readonly Mock<IClass302> aClass;

        public Test302()
        {
            this.aClass = new Mock<IClass302>();
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
