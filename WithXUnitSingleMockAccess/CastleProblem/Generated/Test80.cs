using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test80
    {
        private readonly Mock<IClass80> aClass;

        public Test80()
        {
            this.aClass = new Mock<IClass80>();
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
