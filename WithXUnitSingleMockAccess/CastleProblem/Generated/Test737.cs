using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test737
    {
        private readonly Mock<IClass737> aClass;

        public Test737()
        {
            this.aClass = new Mock<IClass737>();
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
