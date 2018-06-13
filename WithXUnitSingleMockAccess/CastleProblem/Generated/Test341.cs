using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test341
    {
        private readonly Mock<IClass341> aClass;

        public Test341()
        {
            this.aClass = new Mock<IClass341>();
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
