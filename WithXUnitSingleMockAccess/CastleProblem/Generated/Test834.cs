using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test834
    {
        private readonly Mock<IClass834> aClass;

        public Test834()
        {
            this.aClass = new Mock<IClass834>();
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
