using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test384
    {
        private readonly Mock<IClass384> aClass;

        public Test384()
        {
            this.aClass = new Mock<IClass384>();
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
