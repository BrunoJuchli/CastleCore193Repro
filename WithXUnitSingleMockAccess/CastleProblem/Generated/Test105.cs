using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test105
    {
        private readonly Mock<IClass105> aClass;

        public Test105()
        {
            this.aClass = new Mock<IClass105>();
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
