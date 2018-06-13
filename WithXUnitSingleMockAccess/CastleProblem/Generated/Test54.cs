using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test54
    {
        private readonly Mock<IClass54> aClass;

        public Test54()
        {
            this.aClass = new Mock<IClass54>();
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
