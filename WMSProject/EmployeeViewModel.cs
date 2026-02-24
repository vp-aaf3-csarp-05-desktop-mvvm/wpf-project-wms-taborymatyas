
namespace WMSProject
{
    /// <summary>
    /// Dolgozó adatok megjelenítésére szolgáló osztály (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";
        /// <summary>
        /// adóazonosító szám
        /// </summary>
        public string TaxNumber { get; } = "12345678-1-42";
        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int DaysOff { get; set; } = 6;
    }
}
