using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test868
    {
        private readonly Mock<IClass868> aClass;

        public Test868()
        {
            this.aClass = new Mock<IClass868>();
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
