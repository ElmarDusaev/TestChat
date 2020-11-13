namespace ChatCommonLib.Models
{
    public class User
    {
        public int Id { get; set; }
        public string SocketId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }

}
