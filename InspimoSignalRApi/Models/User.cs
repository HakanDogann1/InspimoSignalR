namespace InspimoSignalRApi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }

        //public int RoomID { get; set; }
        public Room Room { get; set; }
    }
}
