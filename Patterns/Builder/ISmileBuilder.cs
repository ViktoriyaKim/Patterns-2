namespace Patterns.Builder
{
    internal interface ISmileBuilder
    {
        void CreateHead();

        void CreateEyes();

        void CreateMouth();

        Smile GetSmileType();
    }
}
