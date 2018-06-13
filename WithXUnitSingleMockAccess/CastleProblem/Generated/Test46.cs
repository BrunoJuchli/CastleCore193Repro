using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test46
    {
        private readonly Mock<IClass46> aClass;

        public Test46()
        {
            this.aClass = new Mock<IClass46>();
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
