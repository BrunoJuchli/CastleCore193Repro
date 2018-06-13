using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test528
    {
        private readonly Mock<IClass528> aClass;

        public Test528()
        {
            this.aClass = new Mock<IClass528>();
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
