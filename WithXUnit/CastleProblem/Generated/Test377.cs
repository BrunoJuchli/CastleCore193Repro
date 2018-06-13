using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test377
    {
        private readonly Mock<IClass377> aClass;

        public Test377()
        {
            this.aClass = new Mock<IClass377>();
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
