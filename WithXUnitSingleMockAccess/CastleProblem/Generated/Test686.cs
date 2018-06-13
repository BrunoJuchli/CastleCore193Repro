using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test686
    {
        private readonly Mock<IClass686> aClass;

        public Test686()
        {
            this.aClass = new Mock<IClass686>();
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
