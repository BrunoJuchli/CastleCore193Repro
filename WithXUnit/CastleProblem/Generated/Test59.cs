using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test59
    {
        private readonly Mock<IClass59> aClass;

        public Test59()
        {
            this.aClass = new Mock<IClass59>();
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
