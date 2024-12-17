namespace Teknoroma.BL.Models
{
    public class MyResult
    {
        public bool Success { get; set; }
        public IList<MyError> Errors { get; set; } = new List<MyError>();
    }
}
