using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test92
    {
        private readonly Mock<IClass92> aClass;

        public Test92()
        {
            this.aClass = new Mock<IClass92>();
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
