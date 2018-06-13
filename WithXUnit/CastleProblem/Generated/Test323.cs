using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test323
    {
        private readonly Mock<IClass323> aClass;

        public Test323()
        {
            this.aClass = new Mock<IClass323>();
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
