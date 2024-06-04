namespace Models
{
    public class User
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public bool HasKingHaki { get; set; }
        public AkumaNoMi AkumaNoMi { get; set; }

        public readonly string INSERT = "INSERT INTO USER_AKUMANOMI (USERNAME, USERAGE, HASKINGHAKI, AKUMANOMI_ID) VALUES (@USERNAME, @USERAGE, @HASKINGHAKI, @AKUMANOMI_ID)";
    }
}