using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test595
    {
        private readonly Mock<IClass595> aClass;

        public Test595()
        {
            this.aClass = new Mock<IClass595>();
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
