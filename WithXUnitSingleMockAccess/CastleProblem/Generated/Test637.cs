using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test637
    {
        private readonly Mock<IClass637> aClass;

        public Test637()
        {
            this.aClass = new Mock<IClass637>();
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
