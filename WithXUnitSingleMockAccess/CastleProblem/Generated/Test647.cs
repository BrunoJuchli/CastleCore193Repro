using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test647
    {
        private readonly Mock<IClass647> aClass;

        public Test647()
        {
            this.aClass = new Mock<IClass647>();
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
