using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test978
    {
        private readonly Mock<IClass978> aClass;

        public Test978()
        {
            this.aClass = new Mock<IClass978>();
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
