using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test457
    {
        private readonly Mock<IClass457> aClass;

        public Test457()
        {
            this.aClass = new Mock<IClass457>();
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
