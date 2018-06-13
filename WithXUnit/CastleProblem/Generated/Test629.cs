using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test629
    {
        private readonly Mock<IClass629> aClass;

        public Test629()
        {
            this.aClass = new Mock<IClass629>();
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
