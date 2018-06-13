using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test463
    {
        private readonly Mock<IClass463> aClass;

        public Test463()
        {
            this.aClass = new Mock<IClass463>();
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
