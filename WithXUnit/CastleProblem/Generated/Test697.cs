using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test697
    {
        private readonly Mock<IClass697> aClass;

        public Test697()
        {
            this.aClass = new Mock<IClass697>();
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
