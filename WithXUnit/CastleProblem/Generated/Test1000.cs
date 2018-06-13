using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test1000
    {
        private readonly Mock<IClass1000> aClass;

        public Test1000()
        {
            this.aClass = new Mock<IClass1000>();
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
