using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test525
    {
        private readonly Mock<IClass525> aClass;

        public Test525()
        {
            this.aClass = new Mock<IClass525>();
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
