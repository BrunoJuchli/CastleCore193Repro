using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test193
    {
        private readonly Mock<IClass193> aClass;

        public Test193()
        {
            this.aClass = new Mock<IClass193>();
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
