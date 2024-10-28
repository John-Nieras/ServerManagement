namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Tanauan",
            "Sto. Tomas",
            "Lipa",
            "Calamba",
            "Alaminos"
        };

        public static List<string> GetCities() => cities;

    }
}
