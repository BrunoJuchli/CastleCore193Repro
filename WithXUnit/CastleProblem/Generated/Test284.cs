using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test284
    {
        private readonly Mock<IClass284> aClass;

        public Test284()
        {
            this.aClass = new Mock<IClass284>();
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
