using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test10
    {
        private readonly Mock<IClass10> aClass;

        public Test10()
        {
            this.aClass = new Mock<IClass10>();
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
