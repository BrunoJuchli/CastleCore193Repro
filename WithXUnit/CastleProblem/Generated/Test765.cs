using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test765
    {
        private readonly Mock<IClass765> aClass;

        public Test765()
        {
            this.aClass = new Mock<IClass765>();
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
