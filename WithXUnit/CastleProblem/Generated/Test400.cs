using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test400
    {
        private readonly Mock<IClass400> aClass;

        public Test400()
        {
            this.aClass = new Mock<IClass400>();
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
