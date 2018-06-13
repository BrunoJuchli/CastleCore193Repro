using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test145
    {
        private readonly Mock<IClass145> aClass;

        public Test145()
        {
            this.aClass = new Mock<IClass145>();
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
