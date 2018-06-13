using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test242
    {
        private readonly Mock<IClass242> aClass;

        public Test242()
        {
            this.aClass = new Mock<IClass242>();
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
