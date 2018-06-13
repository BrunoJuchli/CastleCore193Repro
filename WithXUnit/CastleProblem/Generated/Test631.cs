using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test631
    {
        private readonly Mock<IClass631> aClass;

        public Test631()
        {
            this.aClass = new Mock<IClass631>();
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
