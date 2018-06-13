using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test907
    {
        private readonly Mock<IClass907> aClass;

        public Test907()
        {
            this.aClass = new Mock<IClass907>();
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
