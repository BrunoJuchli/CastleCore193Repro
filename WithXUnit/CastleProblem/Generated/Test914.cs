using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test914
    {
        private readonly Mock<IClass914> aClass;

        public Test914()
        {
            this.aClass = new Mock<IClass914>();
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
