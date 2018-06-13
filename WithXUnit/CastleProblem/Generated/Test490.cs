using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test490
    {
        private readonly Mock<IClass490> aClass;

        public Test490()
        {
            this.aClass = new Mock<IClass490>();
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
