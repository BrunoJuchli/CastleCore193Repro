using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test158
    {
        private readonly Mock<IClass158> aClass;

        public Test158()
        {
            this.aClass = new Mock<IClass158>();
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
