using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test142
    {
        private readonly Mock<IClass142> aClass;

        public Test142()
        {
            this.aClass = new Mock<IClass142>();
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
