using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test191
    {
        private readonly Mock<IClass191> aClass;

        public Test191()
        {
            this.aClass = new Mock<IClass191>();
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
