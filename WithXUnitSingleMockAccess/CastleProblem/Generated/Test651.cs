using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test651
    {
        private readonly Mock<IClass651> aClass;

        public Test651()
        {
            this.aClass = new Mock<IClass651>();
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
