using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test146
    {
        private readonly Mock<IClass146> aClass;

        public Test146()
        {
            this.aClass = new Mock<IClass146>();
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
