using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test698
    {
        private readonly Mock<IClass698> aClass;

        public Test698()
        {
            this.aClass = new Mock<IClass698>();
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
