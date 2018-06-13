using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test114
    {
        private readonly Mock<IClass114> aClass;

        public Test114()
        {
            this.aClass = new Mock<IClass114>();
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
