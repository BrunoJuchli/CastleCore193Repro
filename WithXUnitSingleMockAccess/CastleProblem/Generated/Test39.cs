using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test39
    {
        private readonly Mock<IClass39> aClass;

        public Test39()
        {
            this.aClass = new Mock<IClass39>();
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
