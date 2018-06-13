using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test74
    {
        private readonly Mock<IClass74> aClass;

        public Test74()
        {
            this.aClass = new Mock<IClass74>();
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
