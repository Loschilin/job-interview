namespace InterviewProjects.Strategy
{
    public class MyEntity
    {
        public MyEntityType Type { get; }
        public int Numer { get; internal set; }

        public MyEntity(MyEntityType type)
        {
            Type = type;
        }
    }
}