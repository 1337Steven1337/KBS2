namespace Client.Model
{
    public class PredefinedAnswer : AbstractModel
    {
        public override int Id { get; set; }
        public int Question_Id { get; set; }
        public bool Right_Answer { get; set; }
        public string Text { get; set; }

        public Question Question;
    }
}
