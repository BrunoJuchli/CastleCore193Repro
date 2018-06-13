using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test721
    {
        private readonly Mock<IClass721> aClass;

        public Test721()
        {
            this.aClass = new Mock<IClass721>();
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
