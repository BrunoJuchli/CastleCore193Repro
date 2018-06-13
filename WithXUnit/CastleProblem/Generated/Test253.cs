using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test253
    {
        private readonly Mock<IClass253> aClass;

        public Test253()
        {
            this.aClass = new Mock<IClass253>();
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
