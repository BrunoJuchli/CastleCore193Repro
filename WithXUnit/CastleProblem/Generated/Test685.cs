using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test685
    {
        private readonly Mock<IClass685> aClass;

        public Test685()
        {
            this.aClass = new Mock<IClass685>();
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
