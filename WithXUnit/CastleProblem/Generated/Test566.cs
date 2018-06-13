using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test566
    {
        private readonly Mock<IClass566> aClass;

        public Test566()
        {
            this.aClass = new Mock<IClass566>();
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
