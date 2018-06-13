using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test79
    {
        private readonly Mock<IClass79> aClass;

        public Test79()
        {
            this.aClass = new Mock<IClass79>();
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
