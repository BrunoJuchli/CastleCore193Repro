using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test58
    {
        private readonly Mock<IClass58> aClass;

        public Test58()
        {
            this.aClass = new Mock<IClass58>();
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
