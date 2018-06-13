using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test182
    {
        private readonly Mock<IClass182> aClass;

        public Test182()
        {
            this.aClass = new Mock<IClass182>();
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
