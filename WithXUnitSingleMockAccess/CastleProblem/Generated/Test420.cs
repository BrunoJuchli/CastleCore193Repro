using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test420
    {
        private readonly Mock<IClass420> aClass;

        public Test420()
        {
            this.aClass = new Mock<IClass420>();
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
