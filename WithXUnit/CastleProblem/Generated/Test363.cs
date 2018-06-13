using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test363
    {
        private readonly Mock<IClass363> aClass;

        public Test363()
        {
            this.aClass = new Mock<IClass363>();
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
