namespace Patterns.Builder
{
    internal class Director
    {
        public Smile Construct(ISmileBuilder builder)
        {
            builder.CreateHead();
            builder.CreateEyes();
            builder.CreateMouth();
            return builder.GetSmileType();
        }
    }
}
