using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test415
    {
        private readonly Mock<IClass415> aClass;

        public Test415()
        {
            this.aClass = new Mock<IClass415>();
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
