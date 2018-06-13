using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test939
    {
        private readonly Mock<IClass939> aClass;

        public Test939()
        {
            this.aClass = new Mock<IClass939>();
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
