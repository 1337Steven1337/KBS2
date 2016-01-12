namespace Client.Model
{
    class DocentAccount : AbstractModel
    {
        public override int Id { get; set; }
        public string Docent { get; set; }
        public string Password { get; set; }
    }
}
