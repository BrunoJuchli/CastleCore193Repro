using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test102
    {
        private readonly Mock<IClass102> aClass;

        public Test102()
        {
            this.aClass = new Mock<IClass102>();
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
