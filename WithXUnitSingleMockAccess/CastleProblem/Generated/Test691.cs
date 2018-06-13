using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test691
    {
        private readonly Mock<IClass691> aClass;

        public Test691()
        {
            this.aClass = new Mock<IClass691>();
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
