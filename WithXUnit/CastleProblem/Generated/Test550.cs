using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test550
    {
        private readonly Mock<IClass550> aClass;

        public Test550()
        {
            this.aClass = new Mock<IClass550>();
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
