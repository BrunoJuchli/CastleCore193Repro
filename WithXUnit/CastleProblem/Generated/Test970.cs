using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test970
    {
        private readonly Mock<IClass970> aClass;

        public Test970()
        {
            this.aClass = new Mock<IClass970>();
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
