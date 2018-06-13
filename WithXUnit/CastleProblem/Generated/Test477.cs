using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test477
    {
        private readonly Mock<IClass477> aClass;

        public Test477()
        {
            this.aClass = new Mock<IClass477>();
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
