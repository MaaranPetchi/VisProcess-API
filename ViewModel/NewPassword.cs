namespace VisProcess.ViewModel
{
    public class NewPassword
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string LatestPassword { get; set; }
        public string ConformPassword { get; set; }
    }
}
