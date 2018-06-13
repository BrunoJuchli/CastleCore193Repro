using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test888
    {
        private readonly Mock<IClass888> aClass;

        public Test888()
        {
            this.aClass = new Mock<IClass888>();
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
