namespace Water
{
    public interface ILake
    {
        int BerthsQty { get; set; }

        int BoggingLevel { get; set; }

        int SaltFactor { get; set; }

        int WaterIntakeQty { get; set; }

        int compareLakesByWaterIntakeQuality(Lake l1, Lake l2);

        int compareLakesByBerthsQuality(Lake l1, Lake l2);

        int compareLakesByBoggingLevel(Lake l1, Lake l2);

        int compareLakesBySaltFactor(Lake l1, Lake l2);

        int compareLakesByName(Lake l1, Lake l2);
    }
}