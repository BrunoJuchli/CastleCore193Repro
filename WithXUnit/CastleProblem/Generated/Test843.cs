using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test843
    {
        private readonly Mock<IClass843> aClass;

        public Test843()
        {
            this.aClass = new Mock<IClass843>();
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
