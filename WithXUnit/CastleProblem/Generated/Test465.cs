using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test465
    {
        private readonly Mock<IClass465> aClass;

        public Test465()
        {
            this.aClass = new Mock<IClass465>();
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
