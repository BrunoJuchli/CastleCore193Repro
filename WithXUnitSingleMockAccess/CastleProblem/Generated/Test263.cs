using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test263
    {
        private readonly Mock<IClass263> aClass;

        public Test263()
        {
            this.aClass = new Mock<IClass263>();
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
