using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test130
    {
        private readonly Mock<IClass130> aClass;

        public Test130()
        {
            this.aClass = new Mock<IClass130>();
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
