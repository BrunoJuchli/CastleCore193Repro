using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test738
    {
        private readonly Mock<IClass738> aClass;

        public Test738()
        {
            this.aClass = new Mock<IClass738>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
