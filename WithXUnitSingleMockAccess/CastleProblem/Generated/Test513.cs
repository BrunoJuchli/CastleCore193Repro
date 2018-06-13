using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test513
    {
        private readonly Mock<IClass513> aClass;

        public Test513()
        {
            this.aClass = new Mock<IClass513>();
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
