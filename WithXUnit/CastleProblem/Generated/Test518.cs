using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test518
    {
        private readonly Mock<IClass518> aClass;

        public Test518()
        {
            this.aClass = new Mock<IClass518>();
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
