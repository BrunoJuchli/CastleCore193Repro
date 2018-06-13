using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test919
    {
        private readonly Mock<IClass919> aClass;

        public Test919()
        {
            this.aClass = new Mock<IClass919>();
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
