using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test183
    {
        private readonly Mock<IClass183> aClass;

        public Test183()
        {
            this.aClass = new Mock<IClass183>();
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
