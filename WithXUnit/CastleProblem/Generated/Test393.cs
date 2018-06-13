using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test393
    {
        private readonly Mock<IClass393> aClass;

        public Test393()
        {
            this.aClass = new Mock<IClass393>();
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
