using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test527
    {
        private readonly Mock<IClass527> aClass;

        public Test527()
        {
            this.aClass = new Mock<IClass527>();
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
