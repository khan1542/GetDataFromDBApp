using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace GetDataFromDBApp
{
    public class Pokazateli
    {
        /// <summary>
        /// Полезный объем, м3
        /// </summary>
        public double UsefulVolume { get; set; }
        /// <summary>
        /// Номинальное время работы, сутки
        /// </summary>
        public double RatedOperatinTime { get; set; }
        /// <summary>
        /// Производство среднесуточное, т
        /// </summary>
        public double AveragDailyProduction { get; set; }
        /// <summary>
        /// КИПО
        /// </summary>
        public double KIPO { get; set; }
        /// <summary>
        /// Удельная производительность, т/м3
        /// </summary>
        public double SpecProductivity { get; set; }
        /// <summary>
        /// Интенсивность плавки по руде, кг/м3 сутки
        /// </summary>
        public double IntensityOfSmeltingOre { get; set; }
        /// <summary>
        /// Интенсивность плавки по сожж.C, кг/м3 сутки
        /// </summary>
        public double IntensityOfSmeltingBurntC { get; set; }
        /// <summary>
        /// Выход расч.шлака, кг/т чугуна
        /// </summary>
        public double CalculatedSlagOutput { get; set; }
        /// <summary>
        /// Содержание железа в железорудной части шихты,%
        /// </summary>
        public double IronInIronOre { get; set; }
        /// <summary>
        /// Содержание железа в рудной части шихты,%
        /// </summary>
        public double IronInOre { get; set; }
        /// <summary>
        /// Доля в железорудной части шихты: агломерата, %
        /// </summary>
        public double AgglomeratePart_Percent { get; set; }
        /// <summary>
        /// Доля в железорудной части шихты: окатышей, %
        /// </summary>
        public double PelletsPart_Percent { get; set; }
        /// <summary>
        /// Рудная нагрузка, т/т влажного кокса
        /// </summary>
        public double OreLoad_Wet { get; set; }
        /// <summary>
        /// Рудная нагрузка, т/т сухого кокса
        /// </summary>
        public double OreLoad_Dry { get; set; }
        /// <summary>
        /// Осадки, шт
        /// </summary>
        public double Sediments { get; set; }
        /// <summary>
        /// Количество перешихтовок, шт
        /// </summary>
        public double NumberBlends { get; set; }
        /// <summary>
        /// Расход холодного дутья (ЦЭСТ), м3/мин
        /// </summary>
        public double BlastConsumption_Cold { get; set; }
        /// <summary>
        /// Давление горячего дутья, ати
        /// </summary>
        public double BlastPressure_Hot { get; set; }
        /// <summary>
        /// Температура горячего дутья (факт), С
        /// </summary>
        public double BlastTemperature_Hot_Actual { get; set; }
        /// <summary>
        /// Влажность дутья, г/м3
        /// </summary>
        public double BlastHumidity { get; set; }
        /// <summary>
        /// Содержание кислорода в дутье, %
        /// </summary>
        public double BlastAmountOfOxygen { get; set; }
        /// <summary>
        /// Чистота кислорода,%
        /// </summary>
        public double OxygenPurity { get; set; }
        /// <summary>
        /// Отношение природного газа к дутью,%
        /// </summary>
        public double NaturalGasRatioToBlast { get; set; }
        /// <summary>
        /// Давление колошникового газа, ати
        /// </summary>
        public double FurnaceTopGasPressure { get; set; }
        /// <summary>
        /// Температура колошника, С
        /// </summary>
        public double FurnaceTopTemperature { get; set; }
        /// <summary>
        /// состав, % CO2
        /// </summary>
        public double Composition_CO2 { get; set; }
        /// <summary>
        /// CO
        /// </summary>
        public double Composition_CO { get; set; }
        /// <summary>
        /// H2
        /// </summary>
        public double Composition_H2 { get; set; }
        /// <summary>
        /// Использование CO, %
        /// </summary>
        public double Usage_CO { get; set; }
        /// <summary>
        /// Диаметр воздушных фурм (сред.), мм
        /// </summary>
        public double AirLanceDiameterAVG { get; set; }
        /// <summary>
        /// Химический состав чугуна, % Si
        /// </summary>
        public double CastIron_Si_Pct { get; set; }
        /// <summary>
        /// Mn
        /// </summary>
        public double CastIron_Mn_Pct { get; set; }
        /// <summary>
        /// S
        /// </summary>
        public double CastIron_S_Pct { get; set; }
        /// <summary>
        /// Ti
        /// </summary>
        public double CastIron_Ti_Pct { get; set; }
        /// <summary>
        /// P
        /// </summary>
        public double CastIron_P_Pct { get; set; }
        /// <summary>
        /// Cr
        /// </summary>
        public double CastIron_Cr_Pct { get; set; }
        /// <summary>
        /// C
        /// </summary>
        public double CastIron_C_Pct { get; set; }
        /// <summary>
        /// Химический состав шлака, % SiO2
        /// </summary>
        public double Slag_Si_Pct { get; set; }
        /// <summary>
        /// Al2O3
        /// </summary>
        public double Slag_Al2O3_Pct { get; set; }
        /// <summary>
        /// CaO
        /// </summary>
        public double Slag_CaO_Pct { get; set; }
        /// <summary>
        /// MgO
        /// </summary>
        public double Slag_MgO_Pct { get; set; }
        /// <summary>
        /// MnO
        /// </summary>
        public double Slag_MnO_Pct { get; set; }
        /// <summary>
        /// FeO
        /// </summary>
        public double Slag_FeO_Pct { get; set; }
        /// <summary>
        /// S
        /// </summary>
        public double Slag_S_Pct { get; set; }
        /// <summary>
        /// TiO2
        /// </summary>
        public double Slag_TiO2_Pct { get; set; }
        /// <summary>
        /// NaO
        /// </summary>
        public double Slag_NaO_Pct { get; set; }
        /// <summary>
        /// Ko
        /// </summary>
        public double Slag_Ko_Pct { get; set; }
        /// <summary>
        /// Основность шлака CaO/SiO2
        /// </summary>
        public double Slag_Basicity_CaO_SiO2 { get; set; }
        /// <summary>
        /// (CaO+MgO)/SiO2
        /// </summary>
        public double Result_CaO_MgO_SiO2 { get; set; }
        /// <summary>
        /// (CaO+MgO)/(SiO2+Al2O3)
        /// </summary>
        public double Result_CaO_MgO_SiO2_Al2O3 { get; set; }
        /// <summary>
        /// Качество чугуна, % S меньше 0.030
        /// </summary>
        public double CastIron_Quality { get; set; }

        /// <summary>
        /// Проплавлено рудной части сырья в сутки, т
        /// </summary>
        public double MeltedOreAmount_Day { get; set; }

        /// <summary>
        /// Сожжено кокса в сутки, влажного т
        /// </summary>
        public double BurntCoke_Day_Wet { get; set; }

    }
}
