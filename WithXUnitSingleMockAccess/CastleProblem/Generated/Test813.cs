using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test813
    {
        private readonly Mock<IClass813> aClass;

        public Test813()
        {
            this.aClass = new Mock<IClass813>();
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
