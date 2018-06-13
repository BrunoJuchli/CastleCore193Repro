using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test559
    {
        private readonly Mock<IClass559> aClass;

        public Test559()
        {
            this.aClass = new Mock<IClass559>();
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
