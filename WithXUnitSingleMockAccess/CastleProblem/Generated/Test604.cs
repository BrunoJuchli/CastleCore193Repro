using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test604
    {
        private readonly Mock<IClass604> aClass;

        public Test604()
        {
            this.aClass = new Mock<IClass604>();
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
