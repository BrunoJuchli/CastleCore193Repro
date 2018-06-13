using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test794
    {
        private readonly Mock<IClass794> aClass;

        public Test794()
        {
            this.aClass = new Mock<IClass794>();
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
