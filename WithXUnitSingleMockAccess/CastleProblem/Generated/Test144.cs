using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test144
    {
        private readonly Mock<IClass144> aClass;

        public Test144()
        {
            this.aClass = new Mock<IClass144>();
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
