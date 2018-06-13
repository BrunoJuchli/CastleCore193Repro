using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test746
    {
        private readonly Mock<IClass746> aClass;

        public Test746()
        {
            this.aClass = new Mock<IClass746>();
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
