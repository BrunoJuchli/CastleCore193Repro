using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test910
    {
        private readonly Mock<IClass910> aClass;

        public Test910()
        {
            this.aClass = new Mock<IClass910>();
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
