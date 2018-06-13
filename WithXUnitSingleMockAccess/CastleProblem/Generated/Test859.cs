using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test859
    {
        private readonly Mock<IClass859> aClass;

        public Test859()
        {
            this.aClass = new Mock<IClass859>();
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
