using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test652
    {
        private readonly Mock<IClass652> aClass;

        public Test652()
        {
            this.aClass = new Mock<IClass652>();
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
