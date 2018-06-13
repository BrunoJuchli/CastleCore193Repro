using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test434
    {
        private readonly Mock<IClass434> aClass;

        public Test434()
        {
            this.aClass = new Mock<IClass434>();
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
