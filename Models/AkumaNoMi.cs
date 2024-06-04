namespace Models
{
    public class AkumaNoMi
    {
        public int Id { get; set; }
        public string TypeFruit { get; set; }
        public string Rarity { get; set; }

        public readonly string INSERT = "INSERT INTO AKUMANOMI (TYPEFRUIT, RARITY) VALUES (@TYPEFRUIT, @RARITY); SELECT CAST(scope_identity() as int)";
    }
}
