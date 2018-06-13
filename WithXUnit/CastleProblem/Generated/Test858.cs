using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test858
    {
        private readonly Mock<IClass858> aClass;

        public Test858()
        {
            this.aClass = new Mock<IClass858>();
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
