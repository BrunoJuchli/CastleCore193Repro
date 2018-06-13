using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test445
    {
        private readonly Mock<IClass445> aClass;

        public Test445()
        {
            this.aClass = new Mock<IClass445>();
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
