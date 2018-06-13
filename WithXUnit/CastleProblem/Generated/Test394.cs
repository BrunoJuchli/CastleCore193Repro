using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test394
    {
        private readonly Mock<IClass394> aClass;

        public Test394()
        {
            this.aClass = new Mock<IClass394>();
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
