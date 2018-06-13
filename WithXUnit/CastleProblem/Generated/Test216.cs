using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test216
    {
        private readonly Mock<IClass216> aClass;

        public Test216()
        {
            this.aClass = new Mock<IClass216>();
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
