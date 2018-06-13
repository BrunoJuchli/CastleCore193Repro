using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test606
    {
        private readonly Mock<IClass606> aClass;

        public Test606()
        {
            this.aClass = new Mock<IClass606>();
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
