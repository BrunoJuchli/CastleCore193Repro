using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test417
    {
        private readonly Mock<IClass417> aClass;

        public Test417()
        {
            this.aClass = new Mock<IClass417>();
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
