using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test234
    {
        private readonly Mock<IClass234> aClass;

        public Test234()
        {
            this.aClass = new Mock<IClass234>();
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
