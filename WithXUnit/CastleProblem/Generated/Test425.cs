using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test425
    {
        private readonly Mock<IClass425> aClass;

        public Test425()
        {
            this.aClass = new Mock<IClass425>();
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
