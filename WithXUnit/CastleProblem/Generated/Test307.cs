using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test307
    {
        private readonly Mock<IClass307> aClass;

        public Test307()
        {
            this.aClass = new Mock<IClass307>();
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
