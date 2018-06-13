using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test881
    {
        private readonly Mock<IClass881> aClass;

        public Test881()
        {
            this.aClass = new Mock<IClass881>();
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
