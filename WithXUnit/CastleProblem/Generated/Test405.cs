using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test405
    {
        private readonly Mock<IClass405> aClass;

        public Test405()
        {
            this.aClass = new Mock<IClass405>();
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
