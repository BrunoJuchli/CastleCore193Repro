using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test100
    {
        private readonly Mock<IClass100> aClass;

        public Test100()
        {
            this.aClass = new Mock<IClass100>();
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
