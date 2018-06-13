using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test682
    {
        private readonly Mock<IClass682> aClass;

        public Test682()
        {
            this.aClass = new Mock<IClass682>();
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
