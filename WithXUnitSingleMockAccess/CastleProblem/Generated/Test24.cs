using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test24
    {
        private readonly Mock<IClass24> aClass;

        public Test24()
        {
            this.aClass = new Mock<IClass24>();
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
