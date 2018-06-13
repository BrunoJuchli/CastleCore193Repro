using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test280
    {
        private readonly Mock<IClass280> aClass;

        public Test280()
        {
            this.aClass = new Mock<IClass280>();
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
