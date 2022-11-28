namespace Week10
{
    public class Team
    {
        public string name;
        public string[] results;
        public int score;

        public Team(string name)
        {
            this.name = name;
            results = new string[3];
        }
    }
}