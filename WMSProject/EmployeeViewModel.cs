
using CommunityToolkit.Mvvm.ComponentModel;

namespace WMSProject
{
    /// <summary>
    /// Dolgozó adatok megjelenítésére szolgáló osztály (szabadnapkezelés)
    /// </summary>
    public partial class EmployeeViewModel : ObservableObject
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
        [ObservableProperty]
        private int szabadnapokSzama;
        private int DaysOff { get; set; } = 6;
        private int VacationDays { get;} = 45;

        public int RemainingDaysOff
        {
            get
            {
                int eredmeny = VacationDays - DaysOff;
                return eredmeny;
            }
        }
    }
}
