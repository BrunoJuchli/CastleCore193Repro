using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test565
    {
        private readonly Mock<IClass565> aClass;

        public Test565()
        {
            this.aClass = new Mock<IClass565>();
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
