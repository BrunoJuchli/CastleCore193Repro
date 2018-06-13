using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test135
    {
        private readonly Mock<IClass135> aClass;

        public Test135()
        {
            this.aClass = new Mock<IClass135>();
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
