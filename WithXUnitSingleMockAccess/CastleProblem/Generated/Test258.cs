using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test258
    {
        private readonly Mock<IClass258> aClass;

        public Test258()
        {
            this.aClass = new Mock<IClass258>();
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
