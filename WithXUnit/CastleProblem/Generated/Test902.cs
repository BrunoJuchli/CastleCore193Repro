using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test902
    {
        private readonly Mock<IClass902> aClass;

        public Test902()
        {
            this.aClass = new Mock<IClass902>();
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
