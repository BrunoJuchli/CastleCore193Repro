using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test3
    {
        private readonly Mock<IClass3> aClass;

        public Test3()
        {
            this.aClass = new Mock<IClass3>();
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
