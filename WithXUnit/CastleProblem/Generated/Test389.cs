using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test389
    {
        private readonly Mock<IClass389> aClass;

        public Test389()
        {
            this.aClass = new Mock<IClass389>();
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
