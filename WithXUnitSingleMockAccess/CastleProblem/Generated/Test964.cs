using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test964
    {
        private readonly Mock<IClass964> aClass;

        public Test964()
        {
            this.aClass = new Mock<IClass964>();
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
