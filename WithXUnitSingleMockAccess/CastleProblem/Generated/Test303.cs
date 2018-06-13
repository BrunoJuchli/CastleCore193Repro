using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test303
    {
        private readonly Mock<IClass303> aClass;

        public Test303()
        {
            this.aClass = new Mock<IClass303>();
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
