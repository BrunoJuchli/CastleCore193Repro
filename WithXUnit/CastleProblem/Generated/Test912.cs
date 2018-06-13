using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test912
    {
        private readonly Mock<IClass912> aClass;

        public Test912()
        {
            this.aClass = new Mock<IClass912>();
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
