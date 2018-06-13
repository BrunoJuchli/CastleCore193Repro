using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test290
    {
        private readonly Mock<IClass290> aClass;

        public Test290()
        {
            this.aClass = new Mock<IClass290>();
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
