using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test992
    {
        private readonly Mock<IClass992> aClass;

        public Test992()
        {
            this.aClass = new Mock<IClass992>();
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
