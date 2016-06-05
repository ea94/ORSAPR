using System;
using System.Collections.Generic;
// ReSharper disable once RedundantUsingDirective


namespace Thermos
{
    /// <summary>
    /// Класс инкапсулирует модель, вызывает построение модели.
    /// </summary>
    public class ThermosModel
    {
        #region Fields

        /// <summary>
        /// Параметры модели.
        /// </summary>
        private readonly ThermosProperties _thermosProperties;

        /// <summary>
        /// САПР API.
        /// </summary>
        private readonly InventorApi _api;


        #endregion

        #region Methods

        /// <summary>
        /// Конструктор с входными параметрами модели.
        /// </summary>
        /// <param name="thermosProperties">Параметры модели</param>
        /// <param name="inventorApi"></param>
        public ThermosModel(ThermosProperties thermosProperties, InventorApi inventorApi)
        {
            _thermosProperties = thermosProperties;
            _api = inventorApi;
        }

        /// <summary>
        /// Функция строит модель.
        /// </summary>
        public void Build()
        {
            BuildThermos();
        }

        /// <summary>
        /// Функция строит термос.
        /// </summary>
        private void BuildThermos()
        {
            var thermosDiameterButtom = _thermosProperties.GetParameter(ParameterType.ThermosDiameterButtom).Value;
            var thermosDiameterCelinderExternal = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCelinderExternal).Value;
            var thermosDiameterCelinderInterior = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCelinderInterior).Value;
            var thermosDiameterNeck = _thermosProperties.GetParameter(ParameterType.ThermosDiameterNeck).Value;
            var thermosDiameterCap = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCap).Value;
            var thermosLengthButtom = _thermosProperties.GetParameter(ParameterType.ThermosLengthButtom).Value;
            var thermosLengthCelinder1 = _thermosProperties.GetParameter(ParameterType.ThermosLengthCelinder1).Value;
            var thermosLengthNeck = _thermosProperties.GetParameter(ParameterType.ThermosLengthNeck).Value;
            var thermosLengthBung = _thermosProperties.GetParameter(ParameterType.ThermosLengthBung).Value;
            var thermosLengthCap = _thermosProperties.GetParameter(ParameterType.ThermosLengthCap).Value;
         




            //Дно корпуса
            var buttom = new List<Tuple<double, double, double>>
            {
                new Tuple<double, double, double>(0, thermosDiameterButtom, thermosLengthButtom),

            };

            foreach (var stage in buttom)
            {
                _api.MakeNewWorkingPlane(2, stage.Item1);
                _api.DrawCircle(0.0, 0.0, stage.Item2);
                _api.ExtrudePositive(stage.Item3);
            }
            //Стенки корпуса
            var celinder = new List<Tuple<double, double, double, double>>
            {
                new Tuple<double, double, double, double>(thermosLengthButtom, thermosDiameterCelinderExternal, thermosDiameterCelinderInterior, thermosLengthCelinder1),
                new Tuple<double, double, double, double>(thermosLengthCelinder1+thermosLengthButtom, thermosDiameterCelinderInterior, thermosDiameterNeck, thermosLengthNeck),
            };

            foreach (var stage in celinder)
            {
                _api.MakeNewWorkingPlane(2, stage.Item1);
                _api.DrawCircle(0.0, 0.0, stage.Item2);
                _api.DrawCircle(0.0, 0.0, stage.Item3);
                _api.ExtrudePositive(stage.Item4);
            }
            //Пробка
            var bung = new List<Tuple<double, double, double>>
            {
                new Tuple<double, double, double>(thermosLengthCelinder1+thermosLengthNeck+thermosLengthNeck+thermosLengthButtom, thermosDiameterNeck, thermosLengthNeck),
                new Tuple<double, double, double>(thermosLengthCelinder1+thermosLengthNeck+thermosLengthButtom, thermosDiameterCelinderInterior, thermosLengthBung),
                new Tuple<double, double, double>(thermosLengthCelinder1+thermosLengthCap+thermosLengthButtom*2, thermosDiameterCap, thermosLengthButtom),
            };

            foreach (var stage in bung)
            {
                _api.MakeNewWorkingPlane(2, stage.Item1);
                _api.DrawCircle(0.0, 0.0, stage.Item2);
                _api.ExtrudeNegative(stage.Item3);

            }
            //Крышка
            var cap = new List<Tuple<double, double, double, double>>
            {
                new Tuple<double, double, double, double>(thermosLengthCelinder1+thermosLengthCap+thermosLengthButtom, thermosDiameterNeck, thermosDiameterCap, thermosLengthCap),
              

            };

            foreach (var stage in cap)
            {
                _api.MakeNewWorkingPlane(2, stage.Item1);
                _api.DrawCircle(0.0, 0.0, stage.Item2);
                _api.DrawCircle(0.0, 0.0, stage.Item3);
                _api.ExtrudeNegative(stage.Item4);

            }
            
            #endregion

        }
    }
}
