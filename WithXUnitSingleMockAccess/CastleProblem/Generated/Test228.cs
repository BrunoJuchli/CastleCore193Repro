using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test228
    {
        private readonly Mock<IClass228> aClass;

        public Test228()
        {
            this.aClass = new Mock<IClass228>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
