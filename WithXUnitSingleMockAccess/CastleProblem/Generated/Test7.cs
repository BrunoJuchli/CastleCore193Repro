using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test7
    {
        private readonly Mock<IClass7> aClass;

        public Test7()
        {
            this.aClass = new Mock<IClass7>();
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
