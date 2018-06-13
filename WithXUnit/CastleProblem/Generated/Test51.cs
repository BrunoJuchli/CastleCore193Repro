using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test51
    {
        private readonly Mock<IClass51> aClass;

        public Test51()
        {
            this.aClass = new Mock<IClass51>();
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
