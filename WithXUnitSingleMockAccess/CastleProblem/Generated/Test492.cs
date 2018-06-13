using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test492
    {
        private readonly Mock<IClass492> aClass;

        public Test492()
        {
            this.aClass = new Mock<IClass492>();
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
