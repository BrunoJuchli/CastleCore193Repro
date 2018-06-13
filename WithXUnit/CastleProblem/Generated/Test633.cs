using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test633
    {
        private readonly Mock<IClass633> aClass;

        public Test633()
        {
            this.aClass = new Mock<IClass633>();
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
