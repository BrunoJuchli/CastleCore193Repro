using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test419
    {
        private readonly Mock<IClass419> aClass;

        public Test419()
        {
            this.aClass = new Mock<IClass419>();
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
