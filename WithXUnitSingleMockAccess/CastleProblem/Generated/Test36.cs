using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test36
    {
        private readonly Mock<IClass36> aClass;

        public Test36()
        {
            this.aClass = new Mock<IClass36>();
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
