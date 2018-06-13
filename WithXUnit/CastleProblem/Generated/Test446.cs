using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test446
    {
        private readonly Mock<IClass446> aClass;

        public Test446()
        {
            this.aClass = new Mock<IClass446>();
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
