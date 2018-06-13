using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test608
    {
        private readonly Mock<IClass608> aClass;

        public Test608()
        {
            this.aClass = new Mock<IClass608>();
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
