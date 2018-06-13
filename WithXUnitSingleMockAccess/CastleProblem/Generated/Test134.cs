using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test134
    {
        private readonly Mock<IClass134> aClass;

        public Test134()
        {
            this.aClass = new Mock<IClass134>();
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
