using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test501
    {
        private readonly Mock<IClass501> aClass;

        public Test501()
        {
            this.aClass = new Mock<IClass501>();
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
