using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test343
    {
        private readonly Mock<IClass343> aClass;

        public Test343()
        {
            this.aClass = new Mock<IClass343>();
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
