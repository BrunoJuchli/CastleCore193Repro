using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test619
    {
        private readonly Mock<IClass619> aClass;

        public Test619()
        {
            this.aClass = new Mock<IClass619>();
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
