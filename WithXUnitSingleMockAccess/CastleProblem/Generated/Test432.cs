using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test432
    {
        private readonly Mock<IClass432> aClass;

        public Test432()
        {
            this.aClass = new Mock<IClass432>();
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
