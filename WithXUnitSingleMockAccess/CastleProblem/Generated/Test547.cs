using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test547
    {
        private readonly Mock<IClass547> aClass;

        public Test547()
        {
            this.aClass = new Mock<IClass547>();
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
