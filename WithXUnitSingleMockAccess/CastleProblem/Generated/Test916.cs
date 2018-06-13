using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test916
    {
        private readonly Mock<IClass916> aClass;

        public Test916()
        {
            this.aClass = new Mock<IClass916>();
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
