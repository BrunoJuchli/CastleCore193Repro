using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test62
    {
        private readonly Mock<IClass62> aClass;

        public Test62()
        {
            this.aClass = new Mock<IClass62>();
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
