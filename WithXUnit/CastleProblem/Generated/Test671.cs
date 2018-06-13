using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test671
    {
        private readonly Mock<IClass671> aClass;

        public Test671()
        {
            this.aClass = new Mock<IClass671>();
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
