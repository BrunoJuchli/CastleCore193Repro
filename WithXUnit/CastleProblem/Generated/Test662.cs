using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test662
    {
        private readonly Mock<IClass662> aClass;

        public Test662()
        {
            this.aClass = new Mock<IClass662>();
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
