using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test944
    {
        private readonly Mock<IClass944> aClass;

        public Test944()
        {
            this.aClass = new Mock<IClass944>();
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
