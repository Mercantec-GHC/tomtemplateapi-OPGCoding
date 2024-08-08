namespace BlazorApp1.Components.Pages
{
    public class APIData
    {
        public string DieselDataJson { get; set; }
        public string PatrolDataJson { get; set; }

        public List<Data> DieselData { get; set; }
        public List<Data> PatrolData { get; set; }
    }
}
