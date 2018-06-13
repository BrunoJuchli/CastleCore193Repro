using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test65
    {
        private readonly Mock<IClass65> aClass;

        public Test65()
        {
            this.aClass = new Mock<IClass65>();
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
