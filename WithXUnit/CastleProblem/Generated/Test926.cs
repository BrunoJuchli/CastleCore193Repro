using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test926
    {
        private readonly Mock<IClass926> aClass;

        public Test926()
        {
            this.aClass = new Mock<IClass926>();
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
