using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test901
    {
        private readonly Mock<IClass901> aClass;

        public Test901()
        {
            this.aClass = new Mock<IClass901>();
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
