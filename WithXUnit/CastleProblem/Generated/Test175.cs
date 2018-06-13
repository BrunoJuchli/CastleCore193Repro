using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test175
    {
        private readonly Mock<IClass175> aClass;

        public Test175()
        {
            this.aClass = new Mock<IClass175>();
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
