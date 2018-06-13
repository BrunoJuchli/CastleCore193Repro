using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test788
    {
        private readonly Mock<IClass788> aClass;

        public Test788()
        {
            this.aClass = new Mock<IClass788>();
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
