using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test33
    {
        private readonly Mock<IClass33> aClass;

        public Test33()
        {
            this.aClass = new Mock<IClass33>();
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
