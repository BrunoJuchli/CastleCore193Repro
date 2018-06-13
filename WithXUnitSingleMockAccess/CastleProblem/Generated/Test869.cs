using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test869
    {
        private readonly Mock<IClass869> aClass;

        public Test869()
        {
            this.aClass = new Mock<IClass869>();
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
