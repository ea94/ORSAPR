using System.Collections.Generic;
using System;

namespace Thermos
{
    /// <summary>
    /// Параметры модели.
    /// </summary>
    public class ThermosProperties
    {

        /// <summary>
        /// Словарь параметров.
        /// </summary>
        private readonly Dictionary<ParameterType, Parameter> _parameters;
        
        #region Methods

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public ThermosProperties()
        {
            _parameters = new Dictionary<ParameterType, Parameter>
            {
                {ParameterType.ThermosDiameterButtom, new Parameter(50.0, 82.0, 200.0)},
                {ParameterType.ThermosDiameterCelinderExternal, new Parameter(46.0, 80.0, 199.0)},
                {ParameterType.ThermosDiameterCelinderInterior, new Parameter(44.0, 78.0, 197.0)},
                {ParameterType.ThermosDiameterNeck, new Parameter(45.0, 79.0, 198.0)},
                {ParameterType.ThermosDiameterCap, new Parameter(46.0, 82.0, 200.0)},
                {ParameterType.ThermosLengthButtom, new Parameter(1.5, 4.0, 8.0)},
                {ParameterType.ThermosLengthCelinder1, new Parameter(70.0, 180.0, 400.0)},
                {ParameterType.ThermosLengthNeck, new Parameter(10.0, 20.0, 100.0)},
                {ParameterType.ThermosLengthBung, new Parameter(10.0, 20.0, 40.0)},
                {ParameterType.ThermosLengthCap, new Parameter(20.0, 60.0, 140.0)},


            };
            foreach (var parameter in _parameters.Values)
            {
                parameter.ParameterChanged += ParameterOnParameterChanged;
            }
        }

        /// <summary>
        /// Слот, вызываемый при изменении какого-либо параметра модели.
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы</param>
        private void ParameterOnParameterChanged(object sender, EventArgs e)
        {
            Validate();
        }

        /// <summary>
        /// Получить параметр.
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Полученный параметр</returns>
        public Parameter GetParameter(ParameterType parameterType)
        {
            return _parameters[parameterType];
        }




        /// <summary>
        /// Проверка значений и установка ограничений.
        /// </summary>
        private void Validate()
        {
            if (

                _parameters[ParameterType.ThermosDiameterCap].Value >=
                _parameters[ParameterType.ThermosDiameterNeck].Value)
            {
                _parameters[ParameterType.ThermosDiameterCap].Validate();
            }
            else
            {
                throw new ApplicationException("Enter the correct value of the Cap diameter!");
            }
            if (

                _parameters[ParameterType.ThermosDiameterButtom].Value >=
                _parameters[ParameterType.ThermosDiameterCelinderInterior].Value)
            {
                _parameters[ParameterType.ThermosDiameterButtom].Validate();
            }
            else
            {
                throw new ApplicationException("Enter the correct value of the Buttom diameter!");
            }
            if (

               _parameters[ParameterType.ThermosDiameterCelinderExternal].Value >=
               _parameters[ParameterType.ThermosDiameterCelinderInterior].Value)
            {
                _parameters[ParameterType.ThermosDiameterCelinderExternal].Validate();
            }
            else
            {
                throw new ApplicationException("Enter the correct value of the CelinderExternal diameter!");
            }
            if (

               _parameters[ParameterType.ThermosLengthCap].Value >=
               _parameters[ParameterType.ThermosLengthNeck].Value)
            {
                _parameters[ParameterType.ThermosLengthCap].Validate();
            }
            else
            {
                throw new ApplicationException("Enter the correct value of the Cap lenghth!");
            }



            #endregion
        }
    }
}
 