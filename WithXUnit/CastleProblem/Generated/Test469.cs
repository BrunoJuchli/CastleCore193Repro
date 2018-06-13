using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test469
    {
        private readonly Mock<IClass469> aClass;

        public Test469()
        {
            this.aClass = new Mock<IClass469>();
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
