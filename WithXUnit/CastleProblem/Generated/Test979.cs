using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test979
    {
        private readonly Mock<IClass979> aClass;

        public Test979()
        {
            this.aClass = new Mock<IClass979>();
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
