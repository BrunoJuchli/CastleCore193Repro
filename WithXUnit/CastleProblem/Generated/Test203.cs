using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test203
    {
        private readonly Mock<IClass203> aClass;

        public Test203()
        {
            this.aClass = new Mock<IClass203>();
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
