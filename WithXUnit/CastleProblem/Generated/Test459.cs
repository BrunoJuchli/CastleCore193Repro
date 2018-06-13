using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test459
    {
        private readonly Mock<IClass459> aClass;

        public Test459()
        {
            this.aClass = new Mock<IClass459>();
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
