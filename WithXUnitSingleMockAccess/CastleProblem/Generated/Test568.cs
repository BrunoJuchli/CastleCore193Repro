using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test568
    {
        private readonly Mock<IClass568> aClass;

        public Test568()
        {
            this.aClass = new Mock<IClass568>();
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
