using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test397
    {
        private readonly Mock<IClass397> aClass;

        public Test397()
        {
            this.aClass = new Mock<IClass397>();
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
