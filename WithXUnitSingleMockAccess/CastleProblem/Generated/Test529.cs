using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test529
    {
        private readonly Mock<IClass529> aClass;

        public Test529()
        {
            this.aClass = new Mock<IClass529>();
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
